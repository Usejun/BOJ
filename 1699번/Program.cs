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
            var dp = new int[100001];        
            for (int i = 1; i <= n; i++)
            {
                dp[i] = i;
                for (int j = 1; j * j <= i; j++)
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
            }
            Console.WriteLine(dp[n]);
        }
    }
}
