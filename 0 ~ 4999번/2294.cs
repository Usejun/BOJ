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
            int n = input[0], m = input[1];
            var coin = new int[n];
            var dp = Enumerable.Repeat(1 << 20, m + 1).ToArray();
            dp[0] = 0; 

            for (int i = 0; i < n; i++)
                coin[i] = int.Parse(Console.ReadLine());

            foreach (int i in coin)
                for (int j = 0; j <= m; j++)
                    if (j >= i)
                        dp[j] = Math.Min(dp[j], dp[j - i] + 1);

            Console.Write(dp[m] == 1 << 20 ? -1 : dp[m]);

        }
    }
}
