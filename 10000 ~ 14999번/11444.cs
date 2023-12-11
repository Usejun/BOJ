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
            var d = new Dictionary<long, long>();
            long n = long.Parse(Console.ReadLine());
            long MOD = 1_000_000_007;

            Console.WriteLine(Fib(n));

            long Fib(long k)
            {
                if (k == 0) return 0;
                if (k == 1) return 1;
                if (k == 2) return 1;
                if (d.TryGetValue(k, out long v)) return v;
                if (k % 2 == 0) return d[k] = ((2 * Fib(k / 2 - 1) + Fib(k / 2)) * Fib(k / 2)) % MOD;
                else return d[k] = (Fib((k + 1) / 2) * Fib((k + 1) / 2) + Fib(((k + 1) / 2) - 1) * Fib(((k + 1) / 2) - 1)) % MOD;
            }
        }
    }
}
