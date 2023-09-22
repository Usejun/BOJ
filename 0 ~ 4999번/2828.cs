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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0], M = input[1];
            int count = int.Parse(Console.ReadLine());
            int result = 0;
            int index = 1;
            
            for (int i = 0; i < count; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (index > n)
                {
                    result += index - n;
                    index = n;
                }
                else if (index + M - 1 < n)
                {
                    result += n - (index + M - 1);
                    index += n - (index + M - 1);
                }

            }

            Console.WriteLine(result);

        }
    }
}
    
