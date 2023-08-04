using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            int a = input[0], b = input[1];
            while (b > 0)
                (a, b) = (b, a % b);
            Console.WriteLine($"{input[0] / a}:{input[1] / a}");
        }
    }
}
    
