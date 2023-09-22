using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var seat = Console.ReadLine().Replace("LL", "S").Length + 1;
            Console.WriteLine(Math.Min(n, seat));
        }
    }
}
    
