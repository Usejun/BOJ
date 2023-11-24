using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var s = new HashSet<string>();
            var l = new List<string>();
            var c = Enumerable.Repeat(-1, k).ToArray();

            for (int i = 0; i < n; i++)
                l.Add(Console.ReadLine());
            F(0);
            Console.WriteLine(s.Count);

            void F(int depth)
            {
                if (depth == k)
                {
                    s.Add(string.Join("", c.Select(i => l[i])));                
                    return;
                }

                for (int i = 0; i < n; i++) 
                {
                    if (!c.Contains(i))
                    {
                        c[depth] = i;
                        F(depth + 1);
                        c[depth] = -1;
                    }
                }
            }
        }
    }
}