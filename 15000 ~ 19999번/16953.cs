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
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = input[0], m = input[1];
            long min = int.MaxValue;

            Find(n, 1);

            Console.WriteLine(min == int.MaxValue ? -1 : min);

            void Find(long k, int count)
            {
                if (k == m)
                    min = Math.Min(min, count);
                else if (k > m)
                    return;
                else
                {
                    Find(k * 2, count + 1);
                    Find(k * 10 + 1, count + 1);
                }
            }
        }
    }
}
