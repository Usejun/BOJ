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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int from = input[0], to = input[1], count = int.MaxValue;
            n = int.Parse(Console.ReadLine());  
            var relative = new bool[101, 101];
            var visit = new bool[101];

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                relative[input[0], input[1]] = true;
                relative[input[1], input[0]] = true;
            }

            Dfs(from, 0);

            Console.WriteLine(count == int.MaxValue ? -1 : count);

            void Dfs(int f, int depth)
            {
                if (f == to)
                {
                    count = Math.Min(count, depth);
                    return;
                }

                visit[f] = true;

                for (int i = 0; i < 101; i++)
                    if (relative[f, i] && !visit[i])
                        Dfs(i, depth + 1);
            }
        }
    }
}
