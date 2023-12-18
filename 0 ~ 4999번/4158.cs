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
        while (true)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1], count = 0;
            if (n == 0 && m == 0) break;
            var cd = new HashSet<int>();

            for (int i = 0; i < n; i++)
                cd.Add(int.Parse(Console.ReadLine()));

            for (int i = 0; i < m; i++)
                if (cd.Contains(int.Parse(Console.ReadLine())))
                    count++;

            Console.WriteLine(count);
        }
    }
}