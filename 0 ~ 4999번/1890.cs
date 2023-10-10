using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var map = new long[n][];
            var dp = new long[n, n];

            for (int i = 0; i < n; i++)
                map[i] = Console.ReadLine().Split().Select(long.Parse).ToArray();

            dp[0, 0] = 1;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (map[i][j] == 0) break;                                      
                    if (i + map[i][j] < n) dp[map[i][j] + i, j] += dp[i, j];
                    if (j + map[i][j] < n) dp[i, j + map[i][j]] += dp[i, j];
                }
                
            Console.WriteLine(dp[n - 1, n - 1]);
        }
    }
}
    
