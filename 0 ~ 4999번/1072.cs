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
            long x = input[0], y = input[1], z = y * 100 / x;

            if (z >= 99)
            {
                Console.WriteLine(-1);
                return;
            }

            long l = 0, r = x, mid = 0;

            while (l <= r)
            {
                mid = (l + r) / 2;

                long win = (y + mid) * 100 / (x + mid);

                if (win < z + 1) l = mid + 1;
                else r = mid - 1;
            }

            Console.WriteLine(l);
        }
    }
}