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
            int n;
            int[] count = new int[3]; 
            int[][] paper;

            Input();
            Cut(0, 0, n);

            Console.WriteLine(string.Join("\n", count));

            void Input()
            {
                n = int.Parse(Console.ReadLine());
                paper = new int[n][];

                for (int i = 0; i < n; i++)
                    paper[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();                               
            }
            
            void Cut(int x, int y, int length)
            { 
                for (int i = 0; i < length; i++)               
                    for (int j = 0; j < length; j++)
                        if (paper[y][x] != paper[y + i][x + j])
                        {
                            Cut(x, y, length / 3);
                            Cut(x, y + length / 3, length / 3);
                            Cut(x, y + length / 3 * 2, length / 3);

                            Cut(x + length / 3, y, length / 3);
                            Cut(x + length / 3, y + length / 3, length / 3);
                            Cut(x + length / 3, y + length / 3 * 2, length / 3);

                            Cut(x + length / 3 * 2, y, length / 3);
                            Cut(x + length / 3 * 2, y + length / 3, length / 3);
                            Cut(x + length / 3 * 2, y + length / 3 * 2, length / 3);

                            return;
                        }

                count[paper[y][x] + 1]++;                       
            }
        }
    }
}
