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

            int i = 0, j = 0, s = 0, l = 0;
            int max = int.MaxValue;

            while (j < n && i < n)
            {
                if (s < m)
                {
                    s += array[i++];
                    l++;
                }
                else
                {
                    max = Math.Min(max, l);
                    s -= array[j++];
                    l--;
                }                  
            }

            if (s >= m)
                max = Math.Min(max, l);

            while (j < n)
            {
                s -= array[j++];
                l--;
                if (s >= m)
                    max = Math.Min(max, l);
            }
             

            Console.WriteLine(max == int.MaxValue ? 0 : max);
        }
    }
}