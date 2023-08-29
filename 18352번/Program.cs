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
            var sb = new StringBuilder();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1], k = input[2], x = input[3];
            var q = new Queue<int>();
            var graph = new Dictionary<int, List<int>>();
            var point = new int[n + 1];
            
            for (int i = 0; i <= n; i++)           
                graph[i] = new List<int>();

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[input[0]].Add(input[1]);
            }

            point[x] = 1;
            q.Enqueue(x);

            while (q.Count != 0)
            {
                int p = q.Dequeue();
                foreach (var i in graph[p])
                {
                    if (point[i] == 0)
                    {
                        point[i] = point[p] + 1;
                        q.Enqueue(i);
                    }
                }
            }

            for (int i = 0; i <= n; i++)
                if (point[i]-1 == k)
                    sb.Append(i + "\n");

            Console.Write(sb.Length == 0 ? "-1" : sb.ToString());
        }
    }
}
