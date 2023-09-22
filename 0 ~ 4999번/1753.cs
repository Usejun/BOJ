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
            int n = input[0], m = input[1], INF = int.MaxValue;
            int S = int.Parse(Console.ReadLine());
            var graph = Enumerable.Range(0, n + 1).Select(i => new List<(int, int)>()).ToArray();
            var pq = new SortedSet<(int, int)>();
            var dis = Enumerable.Repeat(INF, n + 1).ToArray();
            
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[input[0]].Add((input[2], input[1]));
            }
            
            pq.Add((0, S));
            dis[S] = 0;
            
            while (pq.Count != 0)
            {
                (int wei, int node) = pq.Min;
                pq.Remove(pq.Min);
                foreach ((int nextWei, int next) in graph[node])
                    if (dis[next] > dis[node] + nextWei)
                    {
                        dis[next] = dis[node] + nextWei;
                        pq.Add((wei + nextWei, next));
                    }                
            }
            
            foreach (int i in dis.Skip(1))
                Console.WriteLine(i == INF ? "INF" : i.ToString());
        }
    }
}
    
