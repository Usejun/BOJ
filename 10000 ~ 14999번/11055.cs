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
            var dp = new int[1011];
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
                dp[i] = array[i];

            for (int i = 0; i < n; i++)            
                for (int j = 0; j < i; j++)
                    if (array[i] > array[j])
                        dp[i] = Math.Max(dp[i], dp[j] + array[i]);

            Console.WriteLine(dp.Max());
        }
    }
}
