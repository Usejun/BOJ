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
        static void Main(string[] s)
        {
            int n = int.Parse(Console.ReadLine());
            var map = new int[n][];
            var visit = new bool[n];
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
                map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                visit[i] = true;
                Dfs(i, i, 1, 0);
                visit[i] = false;
            }

            Console.WriteLine(min);

            void Dfs(int start, int now, int depth, int sum)
            {
                if (depth == n)
                {
                    if (map[now][start] == 0) return;
                    min = Math.Min(min, sum + map[now][start]);
                    return;
                }

                for (int i = 0; i < n; i++)
                {
                    if (!visit[i] && map[now][i] != 0)
                    {
                        visit[i] = true;
                        Dfs(start, i, depth + 1, sum + map[now][i]);
                        visit[i] = false;
                    }
                }
            }

            
        }
    }
}