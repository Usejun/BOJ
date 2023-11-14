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
        static void Main(string[] s)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = input[0], m = input[1];
            var array = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var pq = new PriorityQueue<long, long>();
            long r = 0;

            foreach (long i in array)
                pq.Enqueue(i, i);

            for (int i = 0; i < m && pq.Count > 1; i++)
            {
                long a = pq.Dequeue(), b = pq.Dequeue();
                pq.Enqueue(a + b, a + b);
                pq.Enqueue(a + b, a + b);
            }

            while (pq.Count > 0)            
                r += pq.Dequeue();

            Console.WriteLine(r);
        }
    }
}