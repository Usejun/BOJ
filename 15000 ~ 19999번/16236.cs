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

            int n = int.Parse(R());
            var map = new int[n, n];
            var visit = new bool[n, n];
            var dx = new int[] { -1, 0, 0, 1 };
            var dy = new int[] { 0, -1, 1, 0 };
            var q = new Queue<(int, int, int)>();
            (int x, int y) shark = (-1, -1);
            int size = 2, t = 0, eat = 0;

            for (int i = 0; i < n; i++)
            {
                var input = RSI();
                for (int j = 0; j < n; j++)
                {
                    if (input[j] == 9)
                    {
                        shark = (i, j);
                        map[i, j] = 0;
                    }
                    else
                        map[i, j] = input[j];
                }
            }

            while (true)
            {
                (int x, int y, int d) = Find();
                if (x >= n || y >= n || d >= 1000) break;

                eat++;

                if (size == eat)
                {
                    size++;
                    eat = 0;
                }

                t += d;
                shark = (x, y);
                map[x, y] = 0;
            }

            A($"{t}");

            reader.Close();
            Console.Write(sb);

            (int, int, int) Find()
            {
                visit = new bool[n, n];
                (int x, int y, int d) best = (n, n, 1000);
                visit[shark.x, shark.y] = true;
                q.Clear();
                q.Enqueue((shark.x, shark.y, 1));

                while (q.Any())
                {
                    (int x, int y, int depth) = q.Dequeue();

                    if (best.d < depth) break;                                        

                    for (int i = 0; i < 4; i++)
                    {
                        int nx = x + dx[i];
                        int ny = y + dy[i];

                        if (nx < 0 || nx >= n || ny < 0 || ny >= n || map[nx, ny] > size || visit[nx, ny])
                            continue;

                        if (map[nx, ny] != 0 && map[nx, ny] < size)
                        {
                            if (best.d > depth || best.x > nx || (best.x == nx && best.y > ny))
                                best = (nx, ny, depth);                        
                        }
                        else
                            q.Enqueue((nx, ny, depth + 1));

                        visit[nx, ny] = true;
                    }
                }

                return best;
            }
        }
    }
}