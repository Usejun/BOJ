using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = input[1] == "Y" ? 2 : input[1] == "F" ? 3 : 4;
            var set = new HashSet<string>();

            for (int i = 0; i < n; i++)
                set.Add(Console.ReadLine());

            Console.WriteLine(set.Count / (k - 1));
        }
    }
}