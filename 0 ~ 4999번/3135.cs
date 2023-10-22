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
            int n = int.Parse(Console.ReadLine());
            int a = input[0], b = input[1];
            int min = Math.Abs(a - b);

            for (int i = 0; i < n; i++)
                min = Math.Min(min, Math.Abs(int.Parse(Console.ReadLine()) - b) + 1);

            Console.WriteLine(min);
        }
    }
}