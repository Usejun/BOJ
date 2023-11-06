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
            var comp = Console.ReadLine().Split();
            var min = "";
            var max = "";
            int count = 0;

            for (int i = 0; i < 10; i++)
                Compare(i, 0, $"{i}");

            Console.WriteLine($"{max}\n{min}");

            void Compare(int x, int depth, string k)
            {
                if (depth == n)
                {
                    max = k;
                    if (count++ == 0) min = max;                                
                    return;
                }

                for (int i = 0; i < 10; i++)
                    if ((comp[depth] == ">" ? x > i : x < i) && !k.Contains($"{i}"));
            }
        } 
    }
}
