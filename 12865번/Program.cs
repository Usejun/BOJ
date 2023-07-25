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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], k = input[1];
            var list = new List<(int weight, int value)>();
            var dp = new int[k + 1];

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                list.Add((input[0], input[1]));
            }

            for (int i = 0; i < n; i++)
                for (int w = k; w > list[i].weight - 1; w--)
                    dp[w] = Math.Max(dp[w], dp[w - list[i].weight] + list[i].value);

            Console.WriteLine(dp.Max());

        }
    }
}
    
