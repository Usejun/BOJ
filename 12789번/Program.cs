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
            var order = Console.ReadLine().Split().Select(int.Parse).ToList();
            var stack = new Stack<int>();
            int start = 1;

            foreach (int i in order)
            {
                stack.Push(i);
                while (stack.Any() && start == stack.Peek())
                {
                    start++;
                    stack.Pop();
                }
            }

            while (stack.Any() && start++ == stack.Peek()) stack.Pop();

            Console.WriteLine(stack.Any() ? "Sad" : "Nice");
        }
    }
}
