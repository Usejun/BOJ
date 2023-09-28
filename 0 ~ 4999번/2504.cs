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
            var stack = new Stack<char>();
            var bracket = Console.ReadLine();
            int answer = 0;
            int num = 1;

            for (int i = 0; i < bracket.Length; i++)
            {
                if (bracket[i] == '(' || bracket[i] == '[')
                {
                    num = bracket[i] == '(' ? num * 2 : num * 3;
                    stack.Push(bracket[i]);
                }
                else if (stack.Any())
                {
                    if ((stack.Peek() == '(' && bracket[i] == ')')
                     || (stack.Peek() == '[' && bracket[i] == ']'))
                        if (bracket[i - 1] == stack.Peek())
                        {
                            answer += num;
                            num = stack.Peek() == '(' ? num / 2 : num / 3;
                            stack.Pop();
                        }
                        else
                        {
                            num = stack.Peek() == '(' ? num / 2 : num / 3;
                            stack.Pop();
                        }                  
                }                           
            }

            Console.WriteLine(stack.Any() || bracket.Length % 2 == 1 ? 0 : answer);
        }
    }
}
    
