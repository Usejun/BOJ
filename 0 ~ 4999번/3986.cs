using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            var stack = new Stack<char>();
            for (int i = 0; i < n; i++)
            {
                stack.Clear();
                var input = Console.ReadLine().ToCharArray();
                stack.Push(input[0]);
                for (int j = 1; j < input.Length; j++)
                {
                    if (stack.Count != 0 && input[j] == stack.Peek())
                        stack.Pop();
                    else
                        stack.Push(input[j]);
                }
                if (stack.Count == 0)
                    count++;                
            }
            Console.WriteLine(count);
        }
    }
}
    
