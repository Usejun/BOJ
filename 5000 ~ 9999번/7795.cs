using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0) 
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = input[0], m = input[1];
                var a = Console.ReadLine().Split().Select(int.Parse).OrderBy(i => i).ToArray();
                var b = Console.ReadLine().Split().Select(int.Parse).OrderBy(i => i).ToArray();
                int count = 0;

                for (int i = 0; i < n; i++)
                {
                    int l = 0, r = m, mid = 0;
                    while (r > l)
                    {                    
                        mid = (l + r) / 2;

                        if (b[mid] >= a[i])
                            r = mid;
                        else
                            l = mid + 1;
                    }
                    count += r;
                }

                Console.WriteLine(count);
            }
        }
    }
}