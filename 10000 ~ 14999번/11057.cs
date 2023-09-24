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
            var dp = new int[1011, 11];

            for (int i = 1; i <= 10; i++)
                dp[1, i] = i;

            for (int i = 2; i <= n; i++)
                for (int j = 1; j <= 10; j++)
                    dp[i, j] = (dp[i - 1, j] + dp[i, j - 1]) % 10007;

            Console.Write(dp[n, 10]);

        } 
    }
}
