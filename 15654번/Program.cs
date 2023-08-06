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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var sb = new StringBuilder();

            Array.Sort(numbers);

            for (int i = 0; i < n; i++)
                P(1, numbers[i].ToString());                        

            Console.WriteLine(sb);

            void P(int depth, string buffer)
            {
                if (depth == m)
                {
                    sb.Append(buffer).Append('\n');
                    return;
                }                

                for (int i = 0; i < n; i++)               
                    if (!buffer.Split().Contains(numbers[i].ToString()))
                        P(depth + 1, buffer + " " + numbers[i].ToString());      
            }
        }
    }
}
