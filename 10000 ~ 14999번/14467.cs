using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = Enumerable.Repeat(2, 15).ToArray();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int cow = input[0], dir = input[1];
                if (a[cow] != dir && a[cow] != 2) count++;
                a[cow] = dir;
            }

            Console.WriteLine(count);
        }
    }
}