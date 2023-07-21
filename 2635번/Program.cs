using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            int n = int.Parse(Console.ReadLine());
            int max = 1;
            int start = n;

            for (int i = n; i > 0; --i)
            {
                int result = find(n, i, 1);
                if (max < result)
                {
                    start = i;
                    max = result;
                }
            }

            Console.WriteLine(max + 1);
            find(n, start, 1, true);

            int find(int first, int second, int count, bool display = false)
            {
                if (display)
                    Console.Write(first + " ");
                int result = first - second;
                if (result < 0)
                {
                    if (display)
                        Console.Write(second + " ");
                    return count;
                }

                return find(second, result, count + 1, display);
            }
        }
    }
}
    
