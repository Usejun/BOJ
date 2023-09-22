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
            var schedule = new (int day, int money)[n];
            var dp = new int[20];
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                schedule[i] = (input[0], input[1]);
            }

            for (int i = n - 1; i >= 0; --i)
            {
                int time = i + schedule[i].day;
                if (time <= n)
                {
                    dp[i] = Math.Max(schedule[i].money + dp[time], max);
                    max = dp[i];
                }
                else
                {
                    dp[i] = max;
                }
            }
            Console.WriteLine(max);
        }
    }
}
    
