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
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
                Solve();

            Console.WriteLine(sb);

            void Solve()
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = input[0], k = input[1];
                var delay = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var dp = new int[n + 1];
                var l = new List<int>[n + 1];

                for (int i = 0; i < n + 1; i++)
                {
                    l[i] = new List<int>();
                    dp[i] = -1;
                }

                for (int i = 0; i < k; i++)
                {
                    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    int x = input[0], y = input[1];
                    l[y].Add(x);
                }

                int w = int.Parse(Console.ReadLine());

                sb.Append(DFS(w) + "\n");

                int DFS(int p)
                {
                    if (l[p].Count == 0)
                        return delay[p - 1];
                    if (dp[p] != -1) return dp[p];

                    foreach (int i in l[p])                    
                        dp[p] = Math.Max(dp[p], DFS(i) + delay[p - 1]);                         

                    return dp[p];
                }                
            }

        }

    }
}