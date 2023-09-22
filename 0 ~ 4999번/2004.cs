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
            int n = input[0], m = input[1], k = n - m;

            long two = GetCount(n, 2) - GetCount(m, 2) - GetCount(k, 2);
            long five = GetCount(n, 5) - GetCount(m, 5) - GetCount(k, 5);

            Console.WriteLine(Math.Min(two, five));

            long GetCount(int h, int pow)
            {
                long count = 0;

                for (long i = pow; i <= h; i *= pow)
                    count += h / i;

                return count;
            }
        }
    }
}
