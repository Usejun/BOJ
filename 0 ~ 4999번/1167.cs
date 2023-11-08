using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var tree = new List<(int, int)>[n + 1];
            var d = Enumerable.Repeat(987654321, n + 1).ToArray();
            var pq = new PriorityQueue<(int, int), int>();

            for (int i = 1; i <= n; i++)
                tree[i] = new List<(int, int)>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 1; j < input.Length - 2; j += 2)
                    tree[input[0]].Add((input[j], input[j + 1]));
            }

            Dij(1);
            d[0] = -1;
            int max = Array.IndexOf(d, d.Max(), 1, n);
            d = Enumerable.Repeat(987654321, n + 1).ToArray();
            Dij(max);
            d[0] = -1;

            Console.WriteLine(d.Max());

            void Dij(int start)
            {
                d[start] = 0;
                pq.Enqueue((start, 0), 0);

                while (pq.Count != 0)
                {
                    (int x, int v) = pq.Dequeue();

                    if (d[x] < v) continue;

                    foreach ((int nx, int nv) in tree[x])
                    {
                        if (d[nx] > nv + v)
                        {
                            d[nx] = nv + v;
                            pq.Enqueue((nx, nv + v), nv + v);
                        }
                    }
                }
            }
        }
    }
}
