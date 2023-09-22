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
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dp = new int[1001];

            for (int i = 0; i < 1001; i++)
                dp[i] = 1;        

            for (int i = 1; i < n; i++)
                for (int j = 0; j < i; j++)              
                    if (array[j] < array[i])                    
                        dp[i] = Math.Max(dp[i], dp[j] + 1);

            Console.Write(dp.Max());
        }       
    }
}
    
