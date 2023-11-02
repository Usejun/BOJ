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
            var array = Console.ReadLine().Split().Select(int.Parse).OrderBy(j => j).ToArray();
            int k = int.Parse(Console.ReadLine());
            int i = 0;
            int count = 0;

            for (i = 0; i < array.Length; i++)
                if (array[i] > k) break;

            if (i != 0)
            {
                for (int j = array[i - 1] + 1 ; j <= k; j++)
                    for (int q = array[i] - 1; q >= k; q--)
                        if (j != q) count++;
            }
            else
            {
                for (int j = 1; j <= k; j++)
                    for (int q = array[0] - 1; q >= k; q--)
                        if (j != q) count++;
            }

            Console.WriteLine(count);
        }
    }
}