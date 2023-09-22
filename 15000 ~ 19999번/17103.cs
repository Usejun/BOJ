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
            var prime = new bool[1000001];

            for (int i = 2; i < 1001; i++)
                for (int j = 2; j * i < 1000001; j++)
                    prime[i * j] = true;

            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int count = 0;
                for (int j = n / 2 - 1; j < n - 1; j++)
                    if (!prime[j] && !prime[n - j] && n - j <= j)
                    {
                        Console.WriteLine($"{j} {n - j}");
                        count++;
                    }
                sb.Append(count).Append('\n');
            }
            Console.Write(sb);
        }
    }
}
