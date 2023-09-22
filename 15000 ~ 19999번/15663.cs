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
            var sb = new StringBuilder();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var arr = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            var use = new bool[n];
            var buf = new int[m];

            Dfs(0);

            Console.WriteLine(sb);

            void Dfs(int depth)
            {
                if (depth == m)
                {
                    sb.AppendLine(string.Join(" ", buf));
                    return;
                }

                int set = 0;

                for (int i = 0; i < n; i++)
                {
                    if (use[i] || arr[i] == set)
                        continue;

                    use[i] = true;
                    set = arr[i];
                    buf[depth] = arr[i];
                    Dfs(depth + 1);
                    use[i] = false;
                }
            }


        }
    }
}
