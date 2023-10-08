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
            int MOD = 9901;
            var dp = new int[100001];

            dp[0] = 1;
            dp[1] = 3;

            for (int i = 2; i <= n; i++)            
                dp[i] = dp[i - 2] % MOD + dp[i - 1] * 2 % MOD;

            Console.WriteLine(dp[n] % MOD);
        }
    }
}