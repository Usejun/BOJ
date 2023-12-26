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
            string code = Console.ReadLine();
            int MOD = 1000000, len = code.Length;
            var dp = new int[5001];

            dp[0] = 1;
            dp[1] = 1;

            if (code[0] == '0')
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 2; i <= len; i++)
            {
                if (code[i - 1] != '0') dp[i] = dp[i - 1] % MOD;

                int n = (code[i - 2] - '0') * 10 + (code[i - 1] - '0');
                dp[i] += n <= 26 && n >= 10 ? dp[i - 2] % MOD : 0;
            }

            Console.WriteLine(dp[len] % MOD);
        }
    }
}