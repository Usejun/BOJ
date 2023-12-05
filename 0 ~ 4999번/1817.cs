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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];

            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var book = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int weight = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                weight += book[i];

                if (weight > m)
                {
                    weight = book[i];
                    count++;
                }
                else if (weight == m)
                {
                    weight = 0;
                    count++;
                }                
            }

            Console.WriteLine(weight == 0 ? count : count + 1);
        }
    }
}
    
