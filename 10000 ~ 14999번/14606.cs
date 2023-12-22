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
            Console.Write(n * (n - 1) / 2);
        }
    }
}