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
        static void Main(string[] args)
        {
            var sb = new System.Text.StringBuilder();
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();
            int len = str2.Length;
            var s = new Stack<char>();          

            foreach (char c in str1)
            {
                s.Push(c);
                if (c == str2[len - 1] && len <= s.Count)
                {
                    string t = "";
                    for (int i = 0; i < len; i++)
                        t += s.Pop();
                    t = string.Join("", t.Reverse());
                    if (t != str2)
                        for (int i = 0; i < len; i++)
                            s.Push(t[i]);
                }
            }

            if (s.Count == 0)
            {
                Console.WriteLine("FRULA");
                return;
            }

            while (s.Any())            
                sb.Append(s.Pop());            

            Console.WriteLine(string.Join("", sb.ToString().Reverse()));
        }
    }
}