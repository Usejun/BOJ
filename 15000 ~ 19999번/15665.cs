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
            int n = input[0], length = input[1];
            var nums = Console.ReadLine().Split().Select(int.Parse).Distinct().OrderBy(x => x).ToArray();
            var buf = new int[length];

            Dfs(0);

            Console.WriteLine(sb);

            void Dfs(int depth)
            {
                if (depth == length)
                {
                    sb.AppendLine(string.Join(" ", buf));
                    return;
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    buf[depth] = nums[i];
                    Dfs(depth + 1);
                }
            }
        }
    }
}