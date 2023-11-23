using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1], x = input[2] - 1;
            var graph1 = new List<(int, int)>[n];
            var graph2 = new List<(int, int)>[n];

            for (int i = 0; i < n; i++)
            {
                graph1[i] = new List<(int, int)>();
                graph2[i] = new List<(int, int)>();
            }

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph1[input[0] - 1].Add((input[2], input[1] - 1));
                graph2[input[1] - 1].Add((input[2], input[0] - 1));
            }

            var dij1 = Dij(x, graph1);
            var dij2 = Dij(x, graph2);
            int max = 0;

            for (int i = 0; i < n; i++)            
                max = Math.Max(max, dij1[i] + dij2[i]);

            Console.WriteLine(max);

            int[] Dij(int start, List<(int, int)>[] nodes)
            {
                var dis = Enumerable.Repeat(987654321, n).ToArray();
                var pq = new SortedSet<(int, int)>();

                dis[start] = 0;
                pq.Add((0, start));

                while (pq.Any())
                {
                    (int v, int e) = pq.Min;
                    pq.Remove(pq.Min);

                    if (dis[e] < v) continue;

                    foreach ((int nextV, int next) in nodes[e])
                    {
                        if (nextV + v < dis[next])
                        {
                            dis[next] = nextV + v;
                            pq.Add((nextV + v, next));
                        }
                    }
                }

                return dis;
            }    
        }
    }
}