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
            var dp = new int[21, 21, 21];            

            while (true)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = input[0], b = input[1], c = input[2];
                    
                if (a == -1 && b == -1 && c == -1) break;

                Console.WriteLine($"w({a}, {b}, {c}) = {W(a,b,c)}");
            }

            int W(int a, int b, int c)
            {
                if (a <= 0 || b <= 0 || c <= 0) return 1;
                if (a > 20 || b > 20 || c > 20) return dp[20, 20, 20] = W(20, 20, 20);
                if (dp[a, b, c] != 0) return dp[a, b, c];
                if (a < b && b < c) return dp[a, b, c] = W(a, b, c - 1) + W(a, b - 1, c - 1) - W(a, b - 1, c);
                return dp[a, b, c] = W(a - 1, b, c) + W(a - 1, b - 1, c) + W(a - 1, b, c - 1) - W(a - 1, b - 1, c - 1);               
            }

        }
    }
}
