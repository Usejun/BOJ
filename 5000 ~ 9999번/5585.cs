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
            int n = 1000 - int.Parse(Console.ReadLine());
            int count = 0;
            var coin = new int[] { 500, 100, 50, 10, 5, 1 };

            foreach (int i in coin)
            {
                count += n / i;
                n %= i;
                if (n == 0) break;
            }

            Console.WriteLine(count);
        } 
    }
}
