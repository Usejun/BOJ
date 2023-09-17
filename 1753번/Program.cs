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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1], INF = int.MaxValue;
            int S = int.Parse(Console.ReadLine());
            var graph = Enumerable.Range(0, n + 1).Select(i => new List<Tuple<int, int>>()).ToArray();
            var pq = new PriorityQueue<Tuple<int, int>, int>();
            var dis = Enumerable.Repeat(INF, n + 1).ToArray();

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[input[0]].Add(new Tuple<int, int>(input[1], input[2]));
            }

            pq.Enqueue(new Tuple<int, int>(S, 0), 0);

            while (pq.Count != 0)
            {
                (int node, int wei) = pq.Dequeue();
                if (dis[node] != INF) continue;
                dis[node] = wei;
                foreach ((int newNode, int newWei) in graph[node])
                    pq.Enqueue(new Tuple<int, int>(newNode, wei + newWei), wei + newWei);
            }

            for (int i = 1; i < n + 1; i++)
                Console.WriteLine(dis[i] == INF ? "INF" : dis[i].ToString());      
        }
    }
}
    
