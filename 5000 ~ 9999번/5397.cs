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
            int t = int.Parse(Console.ReadLine());
            var left = new Stack<char>();
            var right = new Stack<char>();

            for (int i = 0; i < t; i++)
            {
                left.Clear();
                right.Clear();

                string password = Console.ReadLine();

                foreach (char c in password)
                {
                    if (c == '<')
                    {
                        if (left.Any())
                            right.Push(left.Pop());
                    }
                    else if (c == '>')
                    {
                        if (right.Any())
                            left.Push(right.Pop());
                    }
                    else if (c == '-')
                    {
                        if (left.Any())
                            left.Pop();

                    }
                    else
                        left.Push(c);
                }
                foreach (var c in left.ToArray().Reverse()) sb.Append(c);
                while (right.Any()) sb.Append(right.Pop());
                sb.Append('\n');
            }
            Console.Write(sb);
        } 
    }
}
