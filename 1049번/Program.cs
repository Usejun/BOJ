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
            int N = input[0], M = input[1], pack = 1001, single = 1001, result = 0;
            
            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (pack > input[0])
                    pack = input[0];
                if (single > input[1])
                    single = input[1];                
            }

            result = N / 6 * pack;
            result += N % 6 * single > pack ? pack : N % 6 * single;

            if (result >= N * single)
                result = N * single;

            Console.WriteLine(result);

        }
    }
}
    
