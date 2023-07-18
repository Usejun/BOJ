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
            var dp = new int[n + 1];
            int min, j;
            dp[0] = 0; dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                min = int.MaxValue;
                j = 1;

                while (j * j <= i)
                {
                    min = Math.Min(min, dp[i - j * j]);
                    j += 1;
                }
                dp[i] = min + 1;
            }
            Console.WriteLine(dp[n]);
        }       
    }
}
    
