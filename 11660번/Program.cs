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
            var sb = new System.Text.StringBuilder();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1], INF = 1 << 7;
            var arr = new List<int>(INF);
            var dp = new List<int>(INF);

            for (int i = 0; i < n; i++)
                arr.AddRange(Console.ReadLine().Split().Select(int.Parse).ToArray());

            dp.Add(arr[0]);

            for (int i = 1; i < n * n; i++)            
                dp.Add(dp[i - 1] + arr[i]);

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(x => int.Parse(x) - 1).ToArray();
                int x1 = input[0], y1 = input[1], x2 = input[2], y2 = input[3];
                int sum = 0;

                for (int j = x1; j <= x2; j++)                
                    sum += dp[j * n + y2] - (j * n + y1 - 1 < 0 ? 0 : dp[j * n + y1 - 1]);

                sb.Append(sum).Append('\n');
            }

            Console.WriteLine(sb);
        }
    }
}
