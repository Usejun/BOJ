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
            int[,] maps = new int[n, n];
            int w = 0, b = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)                
                    maps[i, j] = input[j];                
            }

            Divide(0, 0, n);

            Console.WriteLine(w);
            Console.WriteLine(b);

            void Divide(int x, int y, int max)
            {
                int block = maps[y, x];

                for (int i = y; i < y + max; i++)
                {
                    for (int j = x; j < x + max; j++)
                    {
                        if (block != maps[i, j])
                        {
                            Divide(x, y, max/2);
                            Divide(x, y+max/2, max/2);
                            Divide(x+max/2, y, max/2);
                            Divide(x+max/2, y+max/2, max/2);
                            return;
                        }
                    }
                }

                if (block == 1)
                    b++;
                else
                    w++;
            }
        }
    }
}
