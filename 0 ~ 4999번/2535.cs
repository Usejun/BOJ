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
            int n = int.Parse(Console.ReadLine());

            var score = new int[1001, 2];
            var rank = new int[3, 2];
            int l = 0;

            for (int i = 0; i < n; i++)
            {
                var record = Console.ReadLine().Split().Select(int.Parse).ToArray();
                score[record[2], 0] = record[0];
                score[record[2], 1] = record[1];
            }

            for (int i = 1000; i > 0; i--)
            {
                if (l == 3) break;
                if (score[i, 0] == 0) continue;

                int eq = 0;

                for (int j = 0; j < 3; j++)
                    if (rank[j, 0] == score[i, 0] && eq < 2) eq++;
                    
                if (eq >= 2) continue;

                rank[l, 0] = score[i, 0];    
                rank[l++, 1] = score[i, 1];
            }

            for (int i = 0; i < 3; i++)
                Console.WriteLine($"{rank[i, 0]} {rank[i, 1]}");
        }
    }
} 