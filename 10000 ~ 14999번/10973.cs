using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = n - 2; i >= 0; i--)
            {
                if (a[i] > a[i + 1])
                {
                    int index = i + 1;
                    for (int j = n - 1; j > i; j--)
                        if (a[i] > a[j] && a[j] > a[index])
                            index = j;

                    (a[i], a[index]) = (a[index], a[i]);
                    Array.Sort(a, i + 1, n - i - 1);
                    Array.Reverse(a, i + 1, n - i - 1);

                    Console.Write(string.Join(" ", a));
                    return;
                }
            }

            Console.Write(-1);
        }
    }
}