using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var map = new int[n][];   
            var dx = new int[] { 0, 0, 1, -1 };
            var dy = new int[] { 1, -1, 0, 0 };
            bool[,] visit;

            for (int i = 0; i < n; i++)            
                map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int year = 0;

            while (true) 
            {                
                visit = new bool[n, m];
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        if (map[j][k] != 0 && !visit[j, k])
                        {
                            count++;
                            visit[j, k] = true;
                            DFS(j, k);
                        }
                    }
                }

                if (count > 1)
                {
                    Console.WriteLine(year);
                    return;
                }
                else if (count == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                year++;
            }         

            void DFS(int x, int y)
            {
                int count = 0;
                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    if (nx < 0 || nx >= n || ny < 0 || ny >= m || visit[nx, ny]) continue;
                    if (map[nx][ny] == 0)
                    {
                        count++;
                        continue;
                    }
                    visit[nx, ny] = true;
                    DFS(nx, ny);
                }

                map[x][y] = map[x][y] <= count ? 0 : map[x][y] - count;
            }
        }
    }
}