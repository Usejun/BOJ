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
            var dp = new int[1001];
            dp[1] = 0; dp[2] = 1; dp[3] = 0;
            for (int i = 4; i < n + 1; i++)
            {
                if (dp[i - 1] == 0 || dp[i - 3] == 0)
                    dp[i] = 1;
                else
                    dp[i] = 0;                
            }
            Console.WriteLine(dp[n] == 0 ? "CY" : "SK");
        }
    }
}
    
