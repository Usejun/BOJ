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
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                long n = input[0], m = input[1], k = m - n, answer = 1;

                while (m > 0)
                {
                    answer *= m--;
                    while (n > 0 && answer % n == 0) answer /= n--;
                    while (k > 0 && answer % k == 0) answer /= k--;                                     
                }

                Console.WriteLine(answer);
            }
        }
    }
}
