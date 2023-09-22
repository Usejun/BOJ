using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dp = new long[1000001];
            dp[1] = 1; dp[2] = 2;
            for (int i = 3; i <= n; i++)
                dp[i] = (dp[i - 1]+ dp[i - 2]) % 15746;
            Console.WriteLine(dp[n]);
        }
    }
}   
