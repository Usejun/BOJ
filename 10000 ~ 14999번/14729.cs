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
            var a = new double[n];
            for (int i = 0; i < n; i++)            
                a[i] = double.Parse(Console.ReadLine());
            Array.Sort(a);

            for (int i = 0; i < 7; i++)
                Console.WriteLine($"{a[i]:0.000}");
        }
    }
}