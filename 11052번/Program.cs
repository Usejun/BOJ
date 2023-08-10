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
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var price = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[n + 1];

            dp[1] = price[0];

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= i; j++)
                    dp[i] = Math.Max(dp[i - j] + price[j - 1], dp[i]);

            Console.WriteLine(dp[n]);
        }
    }
}
