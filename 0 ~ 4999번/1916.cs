using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input;
            int INF = int.MaxValue;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            var graph = Enumerable.Range(0, n + 1).Select(x => new List<(int, int)>()).ToList();
            var pq = new SortedSet<(int, int)>();
            var dis = Enumerable.Repeat(INF, n + 1).ToArray();

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[input[0]].Add((input[2], input[1]));
            }

            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int s = input[0], e = input[1];

            pq.Add((0, s));
            dis[s] = 0;

            while (pq.Any())
            {
                (int wei, int node) = pq.Min;
                pq.Remove(pq.Min);
                if (wei > dis[node]) continue;
                foreach ((int nWei, int nNode) in graph[node])
                    if (dis[nNode] > dis[node] + nWei)
                    {
                        dis[nNode] = dis[node] + nWei;
                        pq.Add((wei + nWei, nNode));
                    }
            }
        }
    }
}
