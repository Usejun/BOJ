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
            int length = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int INF = 10000001;

            var floyd = new int[length, length];

            for (int i = 0; i < length; i++)            
                for (int j = 0; j < length; j++)
                    floyd[i, j] = i == j ? 0 : INF;

            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                floyd[input[0] - 1, input[1] - 1] = Math.Min(floyd[input[0] - 1, input[1] - 1], input[2]);
            }

            for (int k = 0; k < length; k++)
                for (int i = 0; i < length; i++)
                    for (int j = 0; j < length; j++)
                        if (floyd[i, j] > floyd[k, j] + floyd[i, k])
                            floyd[i, j] = floyd[k, j] + floyd[i, k];
                            
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)                
                    Console.Write((floyd[i, j] >= INF ? 0 : floyd[i, j]) + " ");
                Console.WriteLine();
            }
        }
    }
}