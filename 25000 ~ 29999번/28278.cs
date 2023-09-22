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
            var stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var com = Console.ReadLine().Split().Select(int.Parse).ToList();
                if (com.Count == 2) stack.Push(com[1]);
                else
                {
                    if (com[0] == 2) sb.Append(stack.Any() ? stack.Pop() : -1).Append("\n");
                    if (com[0] == 3) sb.Append(stack.Count).Append("\n");
                    if (com[0] == 4) sb.Append(stack.Any() ? 0 : 1).Append("\n");
                    if (com[0] == 5) sb.Append(stack.Any() ? stack.Peek() : -1).Append("\n");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
