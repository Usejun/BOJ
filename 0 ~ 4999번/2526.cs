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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1], a = n;
            var list = new List<int>();

            while (!list.Contains(a))
            {
                list.Add(a);
                a = a * n % m;
            }

            Console.WriteLine(list.Count - list.IndexOf(a));
        }
    }
}