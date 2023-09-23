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
            var sb = new System.Text.StringBuilder();
            int t = int.Parse(Console.ReadLine());
            var q = new Queue<(int, int, int)>();
            var dx = new int[] { 1, 2, 1, -2 };
            var dy = new int[] { -2, -1, 2, -1 };
            while (t-- > 0)
            {
                q.Clear();
                int n = int.Parse(Console.ReadLine());
                var s = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var e = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var visit = new bool[n, n];
                int min = int.MaxValue;

                q.Enqueue((s[0], s[1], 0));

                while (q.Any())
                {
                    (int x, int y, int c) = q.Dequeue();

                    if (x == e[0] && y == e[1])
                    {
                        min = Math.Min(c, min);
                        continue;
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        int x1 = x + dx[i];
                        int y1 = y + dy[i];
                        int x2 = x + dy[i];
                        int y2 = y + dx[i];

                        if (x1 >= 0 && x1 < n && y1 >= 0 && y1 < n)
                            if (!visit[x1, y1])
                            {
                                q.Enqueue((x1, y1, c + 1));
                                visit[x1, y1] = true;
                            }
                        if (x2 >= 0 && x2 < n && y2 >= 0 && y2 < n)
                            if (!visit[x2, y2])
                            {
                                q.Enqueue((x2, y2, c + 1));
                                visit[x2, y2] = true;
                            }
                    }                    
                }
                sb.Append(min + "\n");
            }
            Console.Write(sb);
        }
    }
}
