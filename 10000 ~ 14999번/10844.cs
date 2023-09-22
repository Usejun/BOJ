using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            int n = int.Parse(Console.ReadLine());
            var dp = new long[101, 10];
            int mod = 1_000_000_000;
            dp[1, 0] = 0;
            for (int i = 1; i < 10; i++)
                dp[1, i] = 1;

            for (int i = 2; i <= n; i++)            
                for (int j = 0; j < 10; j++)
                    if (j == 0)
                        dp[i, j] = dp[i - 1, j + 1] % mod;
                    else if (j == 9)
                        dp[i, j] = dp[i - 1, j - 1] % mod;
                    else
                        dp[i, j] = dp[i - 1, j - 1] % mod + dp[i - 1, j + 1] % mod;

            Console.WriteLine(Enumerable.Range(0, 10).Sum(x => dp[n, x]) % mod);
        }       
    }
}
    
