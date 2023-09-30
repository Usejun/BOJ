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
            Console.WriteLine(string.Join("\n", Enumerable.Range(1, n).Select(i => new string(' ', n - i) + string.Join("",Enumerable.Repeat("* ", i)))));
        }
    }
}
