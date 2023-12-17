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
            var l = new List<string>();

            for (int i = 0; i < n; i++) l.Add(Console.ReadLine());

            bool inc = l.SequenceEqual(l.OrderBy(i => i));
            bool dec = l.SequenceEqual(l.OrderByDescending(i => i));

            Console.WriteLine(dec ? "DECREASING" : inc ? "INCREASING" : "NEITHER");
        }
    }
}