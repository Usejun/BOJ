using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int i = 0, j = 0, s = array[0], l = 0;
            int max = int.MaxValue;

            while (j < n && i < n)
            {
                if (s < m)
                {
                    i++;
                    if (i >= n) break;
                    s += array[i];
                }
                else
                {
                    max = Math.Min(max, i - j + 1);
                    s -= array[j++];                 
                }                  
            }

            Console.WriteLine(max == int.MaxValue ? 0 : max);
        }
    }
}
