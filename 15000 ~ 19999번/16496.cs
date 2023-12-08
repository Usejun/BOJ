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
            var s = Console.ReadLine().Split().ToArray();
            var sb = new System.Text.StringBuilder();
            var isZero = true;

            Array.Sort(s, Comp);

            for (int i = n - 1; i >= 0; i--)
            { 
                if (isZero) isZero = Zero(s[i]);
                if (!isZero) sb.Append(s[i]);      
            }

            Console.WriteLine(isZero ? "0" : sb);

            int Comp(string n1, string n2)
            {
                return string.Compare(n1 + n2, n2 + n1);
            }
            bool Zero(string s1)
            {
                for (int i = 0; i < s1.Length; i++)            
                    if (s1[i] != '0') return false;            
                return true;
            }
        }
    }
}
