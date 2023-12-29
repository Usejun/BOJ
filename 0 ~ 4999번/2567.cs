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
            int D = 10, SIZE = 121, SPACE = 2, count = 0;
            var a = new int[SIZE, SIZE];

            for (int k = 0; k < n; k++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = input[0] + SPACE, y = input[1] + SPACE;

                for (int i = x; i < x + D; i++)
                    for (int j = y; j < y + D; j++)
                        a[i, j] = 1;
            }

            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                {
                    if (a[i, j] == 1)
                    {
                        if (a[i - 1, j] == 0) count++;
                        if (a[i + 1, j] == 0) count++;
                        if (a[i, j - 1] == 0) count++;
                        if (a[i, j + 1] == 0) count++;  
                    }
                }

            Console.WriteLine(count);
        }
    }
}