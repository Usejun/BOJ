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
            var l = new List<int>();
            int s = 0, c = 0, a = 0;

            for (int i = 0; i < n; i++)
                l.Add(int.Parse(Console.ReadLine()));

            l = l.OrderByDescending(x => x).ToList();

            for (int i = 0; i < n; i++)
            {
                if (c < 2)
                {
                    s += l[i];
                    c++;
                }
                else if (c == 2)
                {
                    a += s;
                    s = 0;
                    c = 0;
                }
            }
                
            Console.WriteLine(a + s);

        }
    }
}