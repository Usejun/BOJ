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
            for (int i = 0; i < t; i++)
            {
                int count = 0;
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = input[0], m = input[1];
                for (int j = n; j <= m; j++)
                    count += j.ToString().Count(x => x == '0');
                Console.WriteLine(count);
            }

        }
    }
}
