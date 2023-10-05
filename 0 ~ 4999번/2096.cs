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
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dpMax = input.ToArray();
            var dpMin = input.ToArray();
            for (int i = 1; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int one = Math.Max(dpMax[0], dpMax[1]) + input[0];
                int two = Math.Max(Math.Max(dpMax[0], dpMax[1]), dpMax[2]) + input[1];
                int three = Math.Max(dpMax[1], dpMax[2]) + input[2];

                (dpMax[0], dpMax[1], dpMax[2]) = (one, two, three);

                one = Math.Min(dpMin[0], dpMin[1]) + input[0];
                two = Math.Min(Math.Min(dpMin[0], dpMin[1]), dpMin[2]) + input[1];
                three = Math.Min(dpMin[1], dpMin[2]) + input[2];

                (dpMin[0], dpMin[1], dpMin[2]) = (one, two, three);
            }

            Console.WriteLine($"{dpMax.Max()} {dpMin.Min()}");

        }
    }
}