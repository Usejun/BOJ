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
            var exp = Console.ReadLine();
            var s = new Stack<char>();
            var r = "";
            var oper = new Dictionary<char, int>
            {
                { '+', 1 },
                { '-', 1 },
                { '*', 2 },
                { '/', 2 },
                { '(', 3 }
            };

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] >= 'A' && exp[i] <= 'Z')
                    r += exp[i];
                else
                {
                    if (exp[i] == ')')
                    {
                        while (s.Any() && s.Peek() != '(')
                            r += s.Pop();
                        s.Pop();
                    }
                    else
                    {
                        while (s.Any() && oper[s.Peek()] >= oper[exp[i]] && s.Peek() != '(')
                            r += s.Pop();
                        s.Push(exp[i]);
                    }                   
                }           
            }

            while (s.Any())
                r += s.Pop();

            Console.WriteLine(r);
        }
    }
}