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
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            var buf = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                while (stack.Any() && stack.Peek() <= array[i])
                    stack.Pop();

                if (!stack.Any())
                    buf[i] = -1;
                else
                    buf[i] = stack.Peek();

                stack.Push(array[i]);
            }

            Console.WriteLine(string.Join(" ", buf));
        }
    }
}
