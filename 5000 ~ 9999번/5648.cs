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
            var list = new List<string>();
            var input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);

            for (int i = 1; i < input.Length; i++)
                list.Add(input[i]);

            while (true)
            {
                if (list.Count == n) break;

                var strings = Console.ReadLine();

                if (strings.Length == 0) continue;

                input = strings.Split();

                foreach (string str in input) 
                    list.Add(str);
            }

            Console.WriteLine(string.Join("\n", list.Select(i => string.Join("", i.Reverse())).Select(i => long.Parse(i)).OrderBy(i => i).ToList()));
        }
    }
}