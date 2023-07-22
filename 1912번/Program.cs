using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {                
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = int.MinValue;
            int number = 0;

            foreach (int i in array)
            {
                number = Math.Max(number + i, i);
                max = Math.Max(max, number);
            }

            Console.WriteLine(max);
        }
    }
}
    
