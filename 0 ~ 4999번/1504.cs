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
            int n = input[0], m = input[1], INF = 10000001;        
            var pq = new PriorityQueue<(int n, int e), int>();
            var node = new List<(int n, int e)>[n];

            for (int i = 0; i < n; i++)
                node[i] = new List<(int n, int e)>();

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = input[0] - 1, b = input[1] - 1, c = input[2];
                node[a].Add((b, c));
                node[b].Add((a, c));
            }        

            var point = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = point[0] - 1, y = point[1] - 1;

            var d0 = Dij(0);
            var dx = Dij(x);
            var dy = Dij(y);
            var dn = Dij(n - 1);

            var lx = d0[x] + dx[y] + dy[n - 1];
            var ly = d0[y] + dy[x] + dx[n - 1];

            var min = Math.Min(lx, ly);

            Console.WriteLine(min >= INF ? -1 : min);

            int[] Dij(int start)
            {
                pq.Clear();
                var d = new int[n];

                for (int i = 0; i < n; i++)
                    d[i] = INF;

                d[start] = 0;
                pq.Enqueue((start, 0), 0);

                while (pq.Count > 0)
                {
                    (int s, int e) = pq.Dequeue();

                    if (d[s] < e) continue;

                    foreach (var i in node[s])
                    {
                        if (i.e + e < d[i.n])
                        {
                            d[i.n] = i.e + e;
                            pq.Enqueue((i.n, i.e + e), i.e + e);
                        }
                    }
                }

                return d;
            }
        }
    }
}
