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
            var prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[n];

            for (int i = 0; i < n; i++)
                dp[i] = 987654321;

            for (int i = 1; i <= n; i++)
            {
                dp[i - 1] = Math.Min(dp[i - 1], prices[i - 1]);
                for (int j = i; j < n; j++)
                    dp[j] = Math.Min(dp[j], prices[i - 1] + dp[j - i]);
            }

            Console.WriteLine(dp[n - 1]);

        }
    }
}