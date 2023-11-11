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
            var sb = new System.Text.StringBuilder();
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long a = input[0], b = input[1], c = Gcd(a, b);

            for (int i = 0; i < c; i++)
                sb.Append(1);

            Console.WriteLine(sb);

            long Gcd(long x, long y)
            {
                return y == 0 ? x : Gcd(y, x % y); 
            }
        }
    }
}