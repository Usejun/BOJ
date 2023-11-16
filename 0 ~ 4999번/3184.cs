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
        static void Main(string[] s)
        {
            var reader = new StreamReader(Console.OpenStandardInput());
            var sb = new System.Text.StringBuilder();
            string R() => reader.ReadLine();
            string[] RS() => R().Split();
            int[] RSI() => RS().Select(int.Parse).ToArray();
            long[] RSL() => RS().Select(long.Parse).ToArray();
            void A(string str) => sb.Append(str);
            void AL(string str) => sb.AppendLine(str);

            var input = RSI();
            int n = input[0], m = input[1];
            var map = new string[n];
            var visit = new bool[n, m];
            var q = new Queue<(int, int)>();
            var dx = new int[] { 0, 0, 1, -1 };
            var dy = new int[] { 1, -1, 0, 0 };
            (int sheep, int wolf) count = (0, 0);

            for (int i = 0; i < n; i++)
                map[i] = R();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (!visit[i, j] && map[i][j] != '#')
                        BFS((i, j));

            A($"{count.sheep} {count.wolf}");

            void BFS((int x, int y) p)
            {
                q.Enqueue(p);

                visit[p.x, p.y] = true;

                int sheep = 0;
                int wolf = 0;

                while (q.Any())
                {
                    (int x, int y) = q.Dequeue();

                    if (map[x][y] == 'o')
                        sheep++;
                    if (map[x][y] == 'v')
                        wolf++;

                    for (int i = 0; i < 4; i++)
                    {
                        int nx = x + dx[i];
                        int ny = y + dy[i];

                        if (nx < 0 || nx >= n || ny < 0 || ny >= m || visit[nx, ny] || map[nx][ny] == '#')
                            continue;

                        q.Enqueue((nx, ny));

                        visit[nx, ny] = true;                        
                    }
                }

                if (sheep > wolf)
                    count.sheep += sheep;
                else 
                    count.wolf += wolf;                
            }
            
            reader.Close();
            Console.Write(sb);
        }
    }
}