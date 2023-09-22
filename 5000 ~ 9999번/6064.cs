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
            var sb = new System.Text.StringBuilder();
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int M = input[0], N = input[1], x = input[2], y = input[3], max = Lcm(M, N);
                while (true)
                {
                    if (x > max || (x - 1) % N + 1 == y) break;
                    x += M;
                }
                sb.AppendLine($"{(x > max ? -1 : x)}");   
            }

            Console.Write(sb);

            int Gcd(int a, int b) => b == 0 ? a : Gcd(b, a % b);
            int Lcm(int a, int b) => a * b / Gcd(a, b);
        }
    }
}
