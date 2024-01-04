using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dir = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };
            int n = input[0], m = input[1];
            var cheese = new int[n, m];
            int time = 0;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)            
                    cheese[i, j] = input[j];            
            }

            while (true)
            {
                bool flag = false;

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (cheese[i, j] == 1) 
                            flag = true;

                if (flag)
                {
                    time++;
                    BFS();
                    cheese = Melt();
                }
                else
                {
                    Console.WriteLine(time);
                    return;
                }
            }

            void BFS()
            {
                var q = new Queue<(int, int)>();
                var visit = new bool[n, m];
                q.Enqueue((0, 0));

                while (q.Any())
                {
                    (int x, int y) = q.Dequeue();

                    for (int i = 0; i < 4; i++)
                    {
                        (int dx, int dy) = dir[i];

                        int nx = x + dx;
                        int ny = y + dy;

                        if (nx < 0 || ny < 0 || nx >= n || ny >= m || visit[nx, ny] || cheese[nx, ny] == 1) 
                            continue;

                        visit[nx, ny] = true;
                        cheese[nx, ny] = 2;
                        q.Enqueue((nx, ny));                                            
                    }
                }
                
            }

            int[,] Melt()
            {
                var cheese2 = new int[n, m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        int count = 0;
                        if (cheese[i, j] == 1)
                        {
                            if (cheese[i - 1, j] == 2) count++;
                            if (cheese[i, j - 1] == 2) count++;
                            if (cheese[i + 1, j] == 2) count++;
                            if (cheese[i, j + 1] == 2) count++;
                        }

                        cheese2[i, j] = cheese[i, j] == 1 && count >= 2 ? 0 : cheese[i, j]; 
                    }
                }

                return cheese2;
            }
        }
    }
}