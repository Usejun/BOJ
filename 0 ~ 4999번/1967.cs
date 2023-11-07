using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var tree = new List<(int, int)>[n + 1];
            var visit = new bool[n + 1];
            int d = 0;

            for (int i = 1; i <= n; i++)            
                tree[i] = new List<(int, int)>();            

            for (int i = 0; i < n - 1; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = input[0], b = input[1], v = input[2];

                tree[a].Add((b, v));
                tree[b].Add((a, v));
            }
                    
            for (int i = 1; i <= n; i++)
            {
                visit[i] = true;
                Dfs(i, 0);
                visit[i] = false;
            }

            Console.WriteLine(d);

            void Dfs(int i, int sum)
            {
                foreach ((int k, int v) in tree[i])
                {
                    if (!visit[k])
                    {
                        visit[k] = true;
                        Dfs(k, sum + v);
                        visit[k] = false;
                    }
                }

                d = Math.Max(d, sum);
            }
        }
    }
}
