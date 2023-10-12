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
            long Gcd(long a, long b)
            {
                while (b > 0) (a, b) = (b, a % b);
                return a;
            }

            long Lcm(long a, long b) => a * b / Gcd(a, b);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                Console.WriteLine(Lcm(input[0], input[1]));
            }
        }
    }
}