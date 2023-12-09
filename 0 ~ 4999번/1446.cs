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
            var dp = Enumerable.Repeat(int.MaxValue, 10001).ToArray();
            var l = new Dictionary<int, Dictionary<int, int>>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = input[0], b = input[1], c = input[2];

                if (!l.ContainsKey(a)) l[a] = new();
                if (l[a].ContainsKey(b)) l[a][b] = Math.Min(l[a][b], c);
                else l[a].Add(b, c);
            }

            dp[0] = 0;

            for (int i = 0; i <= m; i++)
            {
                if (i != 0) dp[i] = Math.Min(dp[i], dp[i - 1] + 1);
                if (l.ContainsKey(i))    
                    foreach ((int k, int v) in l[i])        
                        dp[k] = Math.Min(dp[k], dp[i] + v);            
            }

            Console.WriteLine(dp[m]);
        }
    }
}
