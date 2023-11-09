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
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = input[0], m = input[1];
            var node = new List<(long a, (long b, long v) e)>();
            var parent = new long[n + 1];
            long sum = 0, count = 0;

            for (int i = 0; i < n + 1; i++)
                parent[i] = i;

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                node.Add((input[0], (input[1], input[2])));
            }

            node = node.OrderBy(i => i.e.v).ToList();

            for (int i = 0; i < m; i++)
            {
                (long f, (long t, long vl)) = node[i];

                if (Find(f) == Find(t)) continue;

                sum += vl;
                count++;

                Union(f, t);

                if (count == n) break;
            }

            Console.WriteLine(sum);

            long Find(long v)
            {
                if (parent[v] == v) return v;
                else return parent[v] = Find(parent[v]);
            }

            void Union(long a, long b)
            {
                long fa = Find(a);
                long fb = Find(b);
                if (fa != fb) parent[fa] = fb;
            }
        }
    }
}
