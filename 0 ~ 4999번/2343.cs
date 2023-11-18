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
            long low = array.Max(), high = array.Sum();

            while (low <= high)
            {
                long count = 0, sum = 0, mid = (low + high) / 2;

                for (int i = 0; i < n; i++)
                {
                    if (sum + array[i] > mid)
                    {
                        sum = 0;
                        count++;
                    }
                    sum += array[i];
                }

                if (sum != 0) count++;

                if (count <= m)
                        high = mid - 1;
                else
                    low = mid + 1;                                   
            }

            Console.WriteLine(low);
        }
    }
}