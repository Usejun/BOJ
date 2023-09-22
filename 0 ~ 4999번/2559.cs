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
            int n = input[0], length = input[1], max = 0, sum = 0;
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = 0;

            for (int i = 0; i < length; i++)            
                sum += array[i];
            max = sum;
            
            while (start + length < n)
            {
                sum = sum - array[start] + array[start + length];
                max = Math.Max(max, sum);
                start++;
            }

            Console.WriteLine(max);
        }
    }
}
