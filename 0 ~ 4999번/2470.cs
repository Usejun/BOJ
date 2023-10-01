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
            var water = Console.ReadLine().Split().Select(int.Parse).OrderBy(i => i).ToArray();
            int min = int.MaxValue, start = 0, end = n - 1, x = 0, y = 0;

            while (start < end)
            {
                int sum = water[start] + water[end];
                if (Math.Abs(sum) < min)
                {
                    min = Math.Abs(sum);
                    x = water[start];
                    y = water[end];
                }
                _ = sum < 0 ? start++ : end--;                
            }
            Console.WriteLine(x + " " + y);
        }
    }
}
