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
            var can = Enumerable.Repeat(true, 1000).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 123; i < 999; i++)
            {
                int x = i / 100, y = i / 10 % 10, z = i % 10;

                Console.WriteLine($"{x} {y} {z}");

                if (x == y || y == z || x == z) can[i] = false;
                if (x == 0 || y == 0 || z == 0) can[i] = false;               
            }

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int strike = input[1], ball = input[2];
                for (int j = 123; j < 999; j++)
                {
                    if (can[j])
                    {
                        var f = input[0].ToString();
                        var s = j.ToString();

                        int strike_count = 0;
                        int ball_count = 0;

                        for (int k = 0; k < 3; k++)
                        {
                            for (int q = 0; q < 3; q++)
                            {
                                if (k == q && f[k] == s[q]) strike_count++;
                                if (k != q && f[k] == s[q]) ball_count++;
                            }
                        }

                        if (strike_count != strike || ball_count != ball) can[j] = false;
                    }
                }
            }

            int count = 0;

            for (int i = 123; i < 999; i++)
                if (can[i])
                    count++;

            Console.WriteLine(count);            
        }
    }
}