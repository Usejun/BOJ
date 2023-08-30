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
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = input[0], m = input[1], k = input[2];
            long[] a = new long[1000001], t = new long[4000001];

            for (int i = 0; i < n; i++)
                a[i] = long.Parse(Console.ReadLine());

            I(0, n - 1, 1);

            for (int i = 0; i < m + k; i++)
            {
                input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long c = input[0], s = input[1], e = input[2], d;
                if (c == 1)
                {
                    d = a[s - 1] - e;
                    a[s - 1] = e;
                    U(0, n - 1, 1, s - 1, -d);
                }
                else
                    sb.Append(S(0, n - 1, 1, s - 1, e - 1) + "\n");               
            }

            Console.Write(sb);

            long I(long s, long e, int node)
            {
                if (s == e) return t[node] = a[s];
                var mi = (s + e) / 2;
                return t[node] = I(s, mi, node * 2) + I(mi + 1, e, node * 2 + 1);
            }
            
            long S(long s, long e, int node, long l, long r)
            {
                if (l > e || r < s) return 0;
                if (l <= s && e <= r) return t[node];
                var mi = (s + e) / 2;
                return S(s, mi, node * 2, l, r) + S(mi + 1, e, node * 2 + 1, l, r);
            }

            void U(long s, long e, int node, long i, long d)
            {
                if (i < s || i > e) return;
                t[node] += d;
                if (s == e) return;
                var mi = (s + e) / 2;
                U(s, mi, node * 2, i, d);
                U(mi + 1, e, node * 2 + 1, i, d);
            }
        }
    }
}
