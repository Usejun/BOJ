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
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<(int i, int h)>();

            for (int i = 0; i < input.Length; i++)
            {
                while (stack.Any())
                {
                    if (stack.Peek().h > input[i])
                    {
                        sb.Append($"{stack.Peek().i + 1} ");
                        break;
                    }
                    stack.Pop();
                }
                if (!stack.Any()) sb.Append("0 ");
                stack.Push((i, input[i]));
            }
            Console.WriteLine(sb);
        }
    }
}
