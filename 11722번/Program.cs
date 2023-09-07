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
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                    if (array[i] < array[j])
                        dp[i] = Math.Max(dp[j] + 1, dp[i]);
            }

            Console.WriteLine(dp.Max());
        }
    }
}
