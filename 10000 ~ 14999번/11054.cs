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
            int n = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dpF = Enumerable.Repeat(1, n).ToArray();
            var dpB = Enumerable.Repeat(1, n).ToArray();

            for (int i = 1; i < n; i++)
                for (int j = 0; j < i; j++)                
                    if (arr[j] < arr[i])
                        dpF[i] = Math.Max(dpF[i], dpF[j] + 1);

            for (int i = n - 1; i >= 0; i--)
                for (int j = n - 1; j > i; j--)
                    if (arr[j] < arr[i])
                        dpB[i] = Math.Max(dpB[i], dpB[j] + 1);

            int max = 0;

            for (int i = 0; i < n; i++)
                max = Math.Max(dpB[i] + dpF[i] - 1, max);

            Console.WriteLine(max);
        }
    }
}