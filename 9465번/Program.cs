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
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var sticker = new int[2, 200001];

                for (int j = 0; j < 2; j++)
                {
                    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int k = 0; k < n; k++)
                        sticker[j, k] = input[k];
                }

                sticker[0, 1] += sticker[1, 0];
                sticker[1, 1] += sticker[0, 0];

                for (int j = 2; j < n; j++)
                {
                    sticker[0, j] += Math.Max(sticker[1, j - 1], sticker[1, j - 2]);
                    sticker[1, j] += Math.Max(sticker[0, j - 1], sticker[0, j - 2]);
                }

                Console.WriteLine(Math.Max(sticker[0, n - 1], sticker[1, n - 1]));
            }
        }
    }
}
