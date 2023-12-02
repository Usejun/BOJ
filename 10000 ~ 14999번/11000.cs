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
            int n = int.Parse(Console.ReadLine());
            var l = new List<(int s, int e)>();
            var pq = new PriorityQueue<int, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                l.Add((input[0], input[1]));
            }

            l = l.OrderBy(i => i.s).ToList();

            for (int i = 0; i < n; i++)
            {
                pq.Enqueue(l[i].e, l[i].e);
                if (pq.Peek() <= l[i].s) pq.Dequeue();
            }

            Console.WriteLine(pq.Count);
        }
    }
}