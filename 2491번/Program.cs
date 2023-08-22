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
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[n];
            var dp2 = new int [n];
            dp[0] = 1;
            dp2[0] = 1;

             for (int i = 1; i < n; i++)
             {
                 dp[i] = arr[i - 1] <= arr[i] ? dp[i - 1] + 1 : 1;
                 dp2[i] = arr[i - 1] >= arr[i] ? dp2[i - 1] + 1 : 1;
             }

             Console.WriteLine(Math.Max(dp.Max(), dp2.Max()));
            
        }
    }
}
    
