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
            int n = input[0], k = input[1], answer = 0, len = n.ToString().Length;
            var set = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Bigger(0, 0);

            Console.WriteLine(answer);

            void Bigger(int i, int depth)
            {
                if (depth == len)
                {
                    answer = Math.Max(answer, i);
                    return;
                }

                for (int j = 0; j < k; j++)
                {
                    int t = (int)(set[j] * Math.Pow(10, len - (depth + 1)));
                    t = t == 0 ? set[j] : t;
                    if (i == 0)
                        Bigger(i, depth + 1);
                    if (i + t <= n)
                        Bigger(i + t, depth + 1);               
                }
            }
        }
    }
}