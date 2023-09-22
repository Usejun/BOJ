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
            int y, x, answer = int.MaxValue;
            int[] input, dx = new int[] { 0, 0, 1, -1 },
                         dy = new int[] { 1, -1, 0, 0 };
            string[] map;
            bool[,,] visit;
            Queue<(int, int, bool, int)> q = new Queue<(int, int, bool, int)>();

            Input();
            Solve();

            Console.WriteLine(answer == int.MaxValue ? -1 : answer);

            void Input()
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                (y, x) = (input[0], input[1]);

                map = new string[y];
                visit = new bool[y, x, 2];

                for (int i = 0; i < y; i++)
                    map[i] = Console.ReadLine();

                q.Enqueue((0, 0, false, 1));
            }

            void Solve()
            {
                while (q.Count > 0)
                {
                    (int nx, int ny, bool destroyed, int count) = q.Dequeue();

                    if (nx == x - 1 && ny == y - 1)
                        answer = Math.Min(count, answer);

                    if (!destroyed)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (ny + dy[i] < 0 || ny + dy[i] >= y || nx + dx[i] < 0 || nx + dx[i] >= x)
                                continue;

                            if (map[ny + dy[i]][nx + dx[i]] == '1' && !visit[ny + dy[i], nx + dx[i], 1])
                            {
                                q.Enqueue((nx + dx[i], ny + dy[i], !destroyed, count + 1));
                                visit[ny + dy[i], nx + dx[i], 1] = true;
                            }
                            else if (map[ny + dy[i]][nx + dx[i]] == '0' && !visit[ny + dy[i], nx + dx[i], 0])
                            {
                                q.Enqueue((nx + dx[i], ny + dy[i], destroyed, count + 1));
                                visit[ny + dy[i], nx + dx[i], 0] = true;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (ny + dy[i] < 0 || ny + dy[i] >= y || nx + dx[i] < 0 || nx + dx[i] >= x)
                                continue;

                            if (map[ny + dy[i]][nx + dx[i]] == '0' && !visit[ny + dy[i], nx + dx[i], 1])
                            {
                                q.Enqueue((nx + dx[i], ny + dy[i], destroyed, count + 1));
                                visit[ny + dy[i], nx + dx[i], 1] = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
