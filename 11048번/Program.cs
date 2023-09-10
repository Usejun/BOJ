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
            int n = input[0], m = input[1];
            var map = new int[1001][];
            var dp = new int[1001, 1001];

            for (int i = 0; i < n; i++)
                map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 && j == 0) 
                        dp[i, j] = map[i][j];
                    else if (i == 0)
                        dp[i, j] = dp[i, j - 1] + map[i][j];                  
                    else if (j == 0)
                        dp[i, j] = dp[i - 1, j] + map[i][j];
                    else
                    {
                        int max = 0;
                        max = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                        max = Math.Max(max, dp[i - 1, j - 1]);
                        
                        dp[i, j] = max + map[i][j];
                    }
                }
            }

            Console.WriteLine(dp[n - 1, m - 1]);

        }
    }
}
