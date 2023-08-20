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
            int t = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 0; i < t; i++)
            {
                Console.ReadLine();
                var one = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Array.Sort(one);
                Console.ReadLine();
                var two = Console.ReadLine().Split().Select(int.Parse).ToArray();
                foreach (var n in two)
                    sb.Append(Array.BinarySearch(one, n) < 0 ? 0 : 1).Append("\n");
            }

            Console.WriteLine(sb);
        }
    }
}
