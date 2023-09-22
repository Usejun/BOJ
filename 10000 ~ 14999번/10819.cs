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
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = 0;
            var visit = new bool[n];

            for (int i = 0; i < n; i++)
            {
                visit[i] = true;
                Dfs(i, 0, 1);
                visit[i] = false;
            }

            Console.WriteLine(max);

            void Dfs(int index, int sum, int depth)
            {
                if (depth == n)
                {
                    max = Math.Max(max, sum);
                    return;
                }

                for (int i = 0; i < n; i++)
                {
                    if (!visit[i])
                    {
                        visit[i] = true;
                        Dfs(i, sum + Math.Abs(array[index] - array[i]), depth + 1);
                        visit[i] = false;
                    }
                }
                
            }

        }
    }
}
