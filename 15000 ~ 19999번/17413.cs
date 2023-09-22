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
            var text = Console.ReadLine();
            var stack = new Stack<char>();
            var tag = false;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (c == '<')
                {
                    while (stack.Count > 0) sb.Append(stack.Pop());
                    sb.Append(c);
                    tag = true;
                }
                else if (c == '>')
                {
                    sb.Append(c);
                    tag = false;
                }
                else if (tag)
                    sb.Append(c);
                else if (c == ' ')
                {
                    while (stack.Count > 0) sb.Append(stack.Pop());
                    sb.Append(c);
                }
                else
                    stack.Push(c);
            }
            while (stack.Count > 0) sb.Append(stack.Pop());
            Console.WriteLine(sb);
        }
    }
}
