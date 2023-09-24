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
            int n = input[0], m = input[1], MOD = 1000000000;
            var dp = new long[201, 201];

            for (int i = 0; i < 201; i++)
                for (int j = 0; j < 201; j++)
                    dp[i, j] = 1;
              
            for (int i = 2; i <= m; i++)
                for (int j = 1; j <= n; j++)
                    dp[i, j] = (dp[i - 1, j] + dp[i, j - 1]) % MOD;

            Console.WriteLine(dp[m, n]);
        } 
    }
}
