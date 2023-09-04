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
            BigInteger answer = 1;

            while (n > 1)
            {
                answer *= n--;
                while (m > 1 && answer % m == 0) answer /= m--;
                while (k > 1 && answer % k == 0) answer /= k--;
            }

            Console.WriteLine(m * k == 0 ? answer : answer / (m * k));
        }
    }
}
