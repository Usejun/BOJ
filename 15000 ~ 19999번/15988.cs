using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            var a = new List<int>();
            long MOD = 1000000009;

            for (int i = 0; i < t; i++)
                a.Add(int.Parse(Console.ReadLine()));        

            var dp = new long[1000010];
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 4;

            for (int i = 4; i < 1000001; i++)        
                dp[i] = (dp[i - 1] + dp[i - 2] + dp[i - 3]) % MOD;

            Console.WriteLine(string.Join("\n", a.Select(i => dp[i] % MOD)));
        }
    }
}