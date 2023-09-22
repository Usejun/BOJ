using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main()
        {
            var xArr = new int[2];
            var yArr = new int[2];

            for (int i = 0; i < 2; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                xArr[i] = input[0];
                yArr[i] = input[1];
            }

            xArr[0] *= yArr[1];
            xArr[1] *= yArr[0];            

            long x = xArr.Sum(), y = yArr[0] * yArr[1];
            long a = x, b = y;

            while(b > 0)
                (a, b) = (b, a % b);          

            Console.WriteLine($"{x/a} {y/a}");
        }
    }
}
