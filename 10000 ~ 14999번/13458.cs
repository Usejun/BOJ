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
            var student = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int b = input[0], c = input[1];
            long count = n;

            foreach (int i in student)            
                count += (i - b > 0 ? i - b : 0) / c + ((i - b > 0 ? i - b : 0) % c != 0 ? 1 : 0);

            Console.WriteLine(count);
        }
    }
}