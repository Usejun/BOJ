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
            var l = new List<long>();

            for (int i = 0; i < 10; i++)
                Find(i, 0);

            l.Sort();

            Console.WriteLine(l.Count <= n ? -1 : l[n]);

            void Find(long k, int depth)
            {
                if (depth > 11) return;

                l.Add(k);

                for (int i = 0; i < 10; i++)
                {
                    if (k % 10 > i && !Contains(k, i))
                        Find(k * 10 + i, depth + 1);
                }
            }

            bool Contains(long k, int c)
            {
                while (k / 10 != 0)
                {
                    if (k % 10 == c) return true;
                    k /= 10;
                }

                return false;
            }
        }
    }
}