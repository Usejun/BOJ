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
            var l = new List<(long x, long y)>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                l.Add((input[0], input[1]));
            }

            long sum = 0;

            for (int i = 0; i < n; i++)
                sum += l[i].x * l[(i + 1) % n].y - l[(i + 1) % n].x * l[i].y;

            Console.WriteLine($"{Math.Abs(Math.Round((double)sum / 2, 2)):0.0}");
        }
    }
}