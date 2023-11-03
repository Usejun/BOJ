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
            var dp = new int[10];
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
                dp[i] = dp[i - 1] * 3;

            Console.WriteLine(dp[n]);

        }
    }
}