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
            var connect = new List<int>[n];
            var visit = new bool[n];

            for (int i = 0; i < n; i++)
                connect[i] = new List<int>();

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                connect[input[0]].Add(input[1]);
                connect[input[1]].Add(input[0]);
            }

            for (int i = 0; i < n; i++)
            {
                visit[i] = true;
                Dfs(i, 0);
                visit[i] = false;
            }

            Console.WriteLine(0);

            void Dfs(int k, int depth)
            {
                if (depth == 4)
                {
                    Console.WriteLine(1);
                    Environment.Exit(0);
                }

                foreach (var i in connect[k])
                {
                    if (visit[i]) continue;

                    visit[i] = true;
                    Dfs(i, depth + 1);
                    visit[i] = false;
                }
            }
        }
    }
}