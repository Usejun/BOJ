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
            long count = 0;

            for (int a = 1; a < n; a++)
            {
                for (int b = a; b < n; b++)
                {
                    int c = n - a - b;
                    if (c < b) break;
                    if (a + b > c) count++;                    
                }
            }

            Console.WriteLine(count);
        }
    }
}