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
            var map = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0, height = 0;

            while (height < n)
            {
                height++;
                int i = 0, j;
                while (i < m)
                {
                    if (map[i] < height)
                    {
                        i++;
                        continue;       
                    }

                    for (j = i + 1; j < m; j++)                
                        if (map[j] >= height)
                        {
                            count += j - i - 1;
                            i = j - 1;
                            break;
                        }
                    i++;                
                }
            }

            Console.WriteLine(count);
        }
    }
}