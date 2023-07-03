using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            int n = int.Parse(Console.ReadLine());
            int max = 1;
            int first = n;

            for (int i = n; i > 0 ; --i)
            {
                int r = find(n, i, 1);
                if (max < r)
                {
                    first = i;
                    max = r;
                }
            }

            Console.WriteLine(max + 1);
            find(n, first, 1, true);

            int find(int f, int s, int c, bool display = false)
            {
                if (display)                
                    Console.Write(f + " ");
                int r = f - s;
                if (r < 0)
                {
                    if (display)
                        Console.Write(s + " ");
                    return c;
                }

                return find(s, r, c + 1, display);

            }
        }
    }
}
    
