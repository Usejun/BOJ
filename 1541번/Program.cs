using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            var input = Console.ReadLine().Split('-').Select(s => s.Split('+').Select(int.Parse).Sum()).ToList();
            Console.WriteLine(input[0] * 2 - input.Sum());
        }
    }
}
