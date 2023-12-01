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
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int l = 0, h = n - 1;
            (int l, int h) m = (1000000001, 1000000001);

            while (l < h)
            {
                int sum = Math.Abs(a[l] + a[h]);
                if (sum < Math.Abs(m.l + m.h))
                    (m.l, m.h) = (a[l], a[h]);

                if (a[l] + a[h] > 0) h--;
                else l++;
            }

            Console.WriteLine($"{m.l} {m.h}");
        }
    }
}