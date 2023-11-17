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
            var list = new List<string>();

            for (int i = 0; i < n; i++)
                list.Add(Console.ReadLine());

            Console.WriteLine(string.Join("\n", list.OrderBy(s => s.Length).ThenBy(s => Sum(s)).ThenBy(s => s)));

            int Sum(string s)
            {
                int sum = 0;
                for (int i = 0; i < s.Length; i++)
                    if ('0' <= s[i] && '9' >= s[i])
                        sum += s[i] - '0';
                return sum;
            }
        }
    }
}