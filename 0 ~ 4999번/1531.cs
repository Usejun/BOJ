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
            var img = new int[101, 101];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x1 = input[0], y1 = input[1], x2 = input[2], y2 = input[3];

                for (int j = x1; j <= x2; j++)
                    for (int k = y1; k <= y2; k++)
                        img[j, k]++;               
            }

            for (int i = 0; i < 101; i++)
                for (int j = 0; j < 101; j++)
                    if (img[i, j] > m)
                        count++;

            Console.WriteLine(count);
        }
    }
}