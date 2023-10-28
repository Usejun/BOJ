using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], l = input[1];
            input = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            int count = 0;

            int start = input[0];

            for (int i = 1; i < n; i++)
            {
                if (l <= input[i] - start)
                {
                    count++;
                    start = input[i];
                }
            }

            Console.WriteLine(count+1);
        }
    }
}