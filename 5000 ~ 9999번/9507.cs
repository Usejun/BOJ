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
            var dp = new long[68];
            dp[0] = 1;
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 4;

            for (int i = 4; i < 68; i++)            
                dp[i] = dp[i - 4] + dp[i - 3] + dp[i - 2] + dp[i - 1];

            for (int i = 0; i < n; i++)            
                Console.WriteLine(dp[int.Parse(Console.ReadLine())]);            
        }
    }
}