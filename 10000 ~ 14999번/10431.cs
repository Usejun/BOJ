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
        static void Main(string[] s)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                var array = Console.ReadLine().Split().Select(int.Parse).Skip(1).ToArray();
                for (int j = 0; j < 19; j++)
                {
                    for (int q = 0; q < 19; q++)
                    {
                        if (array[q] > array[q + 1])
                        {
                            (array[q], array[q + 1]) = (array[q + 1], array[q]);
                            count++;
                        }
                    }
                }
                Console.WriteLine($"{i} {count}");
            }
        }
    }
}