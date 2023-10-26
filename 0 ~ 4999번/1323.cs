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
            int n = input[0], k = input[1];
            long length = (long)Math.Pow(10, n.ToString().Length);
            var check = new bool[1000001];

            int count = 1;
            long mod = n % k;

            while (mod != 0)
            {
                mod = (mod * length + n) % k;
                if (check[mod])
                {
                    Console.WriteLine(-1);
                    return;
                }          
                
                check[mod] = true;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}