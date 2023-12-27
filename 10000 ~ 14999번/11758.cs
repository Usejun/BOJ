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
            var p = new (int x, int y)[3];

            for (int i = 0; i < 3; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                p[i] = (input[0], input[1]);
            }

            int result = (p[1].x - p[0].x) * (p[2].y - p[0].y) -
                        (p[2].x - p[0].x) * (p[1].y - p[0].y);

            Console.WriteLine(result == 0 ? 0 : result < 0 ? -1 : 1);
        }
    }
}