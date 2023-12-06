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
            var pq = new PriorityQueue<int, int>();
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                pq.Enqueue(k, k);
            }

            while (pq.Count != 1)
            {
                int a = pq.Dequeue() + pq.Dequeue();
                sum += a;   
                pq.Enqueue(a, a);
            }

            Console.WriteLine(sum);
        }
    }
}
