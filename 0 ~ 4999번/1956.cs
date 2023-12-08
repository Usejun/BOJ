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
            var graph = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i != j) graph[i, j] = INF;

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = input[0] - 1, b = input[1] - 1, c = input[2];
                graph[a, b] = Math.Min(graph[a, b], c);
            }

            for (int k = 0; k < n; k++)        
                for (int i = 0; i < n; i++)  
                    for (int j = 0; j < n; j++)
                        if (graph[i, j] > graph[i, k] + graph[k, j])
                            graph[i, j] = graph[i, k] + graph[k, j];

            int min = INF;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i != j && graph[i, j] != INF && graph[j, i] != INF)
                        min = Math.Min(min, graph[i, j] + graph[j, i]);

            Console.WriteLine(min == INF ? -1 : min);
        }
    }
}