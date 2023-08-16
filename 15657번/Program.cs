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
            var sb = new StringBuilder(); 
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], length = input[1];
            var number = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            var buffer = new int[length];
            var used = new int[n];

            Dfs(0, 0);

            Console.WriteLine(sb);

            void Dfs(int start, int depth)
            {
                if (depth == length)
                {
                    sb.AppendLine(string.Join(" ", buffer));                   
                    return;
                }

                for (int i = start; i < number.Length; i++)
                {
                    buffer[depth] = number[i];
                    Dfs(i, depth + 1);
                }
            }

            
        }
    }
}
