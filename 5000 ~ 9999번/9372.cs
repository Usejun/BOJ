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
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < input[1]; j++)
                    Console.ReadLine();
                Console.WriteLine(input[0] - 1);
            }
        }
    }
}
    
