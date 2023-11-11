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
        static void Main(string[] s)
        {
            int n = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int l = 0, r = n - 1;
            int min = int.MaxValue;

            while (l < r)
            {
                int sum = array[l] + array[r];

                if (Math.Abs(sum) < Math.Abs(min))
                    min = sum;

                if (sum > 0)
                    r--;
                else
                    l++;
            }

            Console.WriteLine(min);
        }
    }
}