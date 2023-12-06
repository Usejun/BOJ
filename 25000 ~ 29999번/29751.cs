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
            var 입력 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            float 밑변 = 입력[0], 높이 = 입력[1];

            Console.WriteLine($"{밑변 * 높이 / 2:0.0}");
        }
    }
}