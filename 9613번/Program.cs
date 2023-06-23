using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long gcd(long a, long b)
            {
                if (b == 0) return a;
                return gcd(b, a % b);
            }

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var array = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long sum = 0;
                for (int j = 1; j < array.Length; j++)
                    for (int k = j + 1; k < array.Length; k++)
                        sum += gcd(array[j], array[k]);
                Console.WriteLine(sum);
            }
        }
    }
}
