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
            var r = () => Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input = r();
            int n = input[0], m = input[1];
            var graph = Enumerable.Range(0, n + 1).Select(i => new List<int>()).ToArray();
            var degree = new int[n + 1];
            var q = new Queue<int>();
            var result = new int[n + 1];

            for (int i = 0; i < m; i++)
            {
                input = r();
                graph[input[0]].Add(input[1]);
                degree[input[1]]++;
            }

            for (int i = 1; i <= n; i++)
                if (degree[i] == 0)
                    q.Enqueue(i);

            for (int i = 1; i <= n; i++)
            {
                int x = q.Dequeue();
                result[i] = x;
                for (int j = 0; j < graph[x].Count; j++)
                {
                    int y = graph[x][j];
                    if (--degree[y] == 0)
                        q.Enqueue(y);
                }
            }

            Console.WriteLine(string.Join(" ", result.Skip(1)));
        }
    }
}