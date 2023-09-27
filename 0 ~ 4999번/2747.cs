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
            var fib = new int[46];
            fib[0] = 0;
            fib[1] = 1;
            fib[2] = 1;

            for (int i = 3; i < 46; i++)
                fib[i] = fib[i - 2] + fib[i - 1];

            Console.WriteLine(fib[n]);
        } 
    }
}
