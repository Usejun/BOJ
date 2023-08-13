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
            var stack = new Stack<char>();
            var input = Console.ReadLine().Replace("()", "|");
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    stack.Push('(');
                else if (input[i] == '|')
                    count += stack.Count;
                else
                {
                    count++;
                    stack.Pop();
                }
            }

            Console.WriteLine(count);
        }
    }
}
