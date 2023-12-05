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
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            var x = "";

            for (int i = 0; i < s.Length * t.Length; i++)            
                x += t;

            Console.WriteLine(x.Replace(s, "") == "" ? 1 : 0);
        }
    }
}