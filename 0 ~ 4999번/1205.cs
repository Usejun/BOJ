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
            int n = input[0], m = input[1], p = input[2];

            if (n == 0)
            {
                Console.WriteLine(1);
                return;
            }

            var score = Console.ReadLine().Split().Select(int.Parse).ToList();
            score.Add(m);
            score = score.OrderByDescending(x => x).ToList();

            if (score.Count > p && score[p] >= m)            
                Console.WriteLine(-1);            
            else
                for (int i = 0; i < score.Count; i++)
                    if (score[i] == m)
                    {
                        Console.WriteLine(i + 1);
                        return;
                    }
        }
    }
}