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
            int len = 111;
            var prime = new bool[len];
            prime[0] = true;
            prime[1] = true;
            for (int i = 2; i < len / 2; i++)
            {
                if (prime[i]) continue;
                for (int j = 1; j < len / 2; j++)
                    if (i * j < len)
                        prime[i * j] = true;
                prime[i] = false;                
            }

            var l = new List<int>();
            for (int i = 0; i < len; i++)
                if (!prime[i]) l.Add(i);

            int n = int.Parse(Console.ReadLine());
            int max = int.MaxValue;

            for (int i = 0; i < l.Count - 1; i++)
                if (n < l[i] * l[i + 1])
                    max = Math.Min(l[i] * l[i + 1], max);

            Console.WriteLine(max);
        }
    }
}