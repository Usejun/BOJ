using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1], count = 0;
            var buf = new int[3];
            var set = new HashSet<int>[n + 1];

            for (int i = 0; i < n + 1; i++)
                set[i] = new HashSet<int>();

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                set[input[0]].Add(input[1]);
                set[input[1]].Add(input[0]);
            }

            DFS(0, 0);

            Console.WriteLine(count);

            void DFS(int k, int depth)
            {
                if (depth == 3)
                {
                    if (!set[buf[0]].Contains(buf[2]))
                    {
                        count++;
                    }
                    return;
                }

                for (int i = k + 1; i <= n; i++)
                    if (!set[k].Contains(i))
                    {
                        buf[depth] = i;
                        DFS(i, depth + 1);
                    }
            }
        }
    }
}