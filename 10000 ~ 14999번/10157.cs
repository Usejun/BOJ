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
            int c = input[0], r = input[1];
            var k = int.Parse(Console.ReadLine());
            var dy = new int[] { 1, 0, -1, 0 };
            var dx = new int[] { 0, 1, 0, -1 };
            int[,] hall = new int[r, c];
            int x = 0, y = 0, dir = 0;           
            int number = 1;
            hall[0, 0] = 1;

            while (number < r * c)
            {
                int nx = x + dx[dir];
                int ny = y + dy[dir];

                if (0 <= ny && ny < r && 0 <= nx && nx < c && hall[ny, nx] == 0)
                {
                    if (number == k)
                    {
                        Console.WriteLine($"{x + 1} {y + 1}");
                        return;
                    }
                    x = nx;
                    y = ny;
                    hall[y, x] = ++number;
                    if (number == k)
                    {
                        Console.WriteLine($"{x + 1} {y + 1}");
                        return;
                    }
                }
                else
                    dir = (dir + 1) % 4;                
            }

            Console.WriteLine(0);
        }
    }
}