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
            var input = Console.ReadLine();
            var a = Console.ReadLine().Split().Select(int.Parse);
            var b = Console.ReadLine().Split().Select(int.Parse);
            var c = a.Except(b);

            Console.WriteLine(c.Any() ? $"{c.Count()}\n{string.Join(" ", c.OrderBy(i=>i))}" : "0");
        }
    }
}