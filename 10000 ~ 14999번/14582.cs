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
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isWin = false;
            int sum = 0;

            for (int i = 0; i < 9; i++)
            {
                sum += a[i];
                if (sum > 0) isWin = true;
                sum -= b[i];
            }

            Console.WriteLine(a.Sum() < b.Sum() && isWin ? "Yes" : "No");

        }
    }
}