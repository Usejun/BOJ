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
            int n = int.Parse(Console.ReadLine());
            var num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 1; i < num.Length; i++)
            {
                int a = num[0];
                int b = num[i];

                while (b > 0)
                    (a, b) = (b, a%b);

                Console.WriteLine($"{num[0] / a}/{num[i] / a}");
            }
        }
    }
}
