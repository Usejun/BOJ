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
            int N = input[0], M = input[1], K = input[2];
            int count = Math.Min(N / 2, M), person = (N - 2 * count) + (M - count);

            while (K - person > 0)
            {
                person += 3;
                count--;
            }

            Console.WriteLine(count < 0 ? 0 : count);
        }
    }
}
    
