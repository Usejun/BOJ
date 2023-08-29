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
            var dp = new BigInteger[1001];
            dp[1] = 0;
            dp[2] = 1;

            for (int i = 3; i <= n; i++)
                dp[i] = i % 2 == 0 ? dp[i - 1] * 2 + 1 : dp[i - 1] * 2 - 1;

            Console.WriteLine(dp[n]);

        }
    }
}
