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
            int[] input;
            int ans = 0;
            var gear = new List<char>[4];

            for (int i = 0; i < 4; i++)
                gear[i] = new List<char>(Console.ReadLine());

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
                int d = input[1], n = input[0] - 1;                
               
                Left(n - 1, -d);
                Right(n + 1, -d);
                Rotate(n, d);
            }

            for (int i = 0, j = 1; i < 4; i++)
            {
                if (gear[i][0] == '1')
                    ans += j;
                j *= 2;
            }

            Console.WriteLine(ans);

            void Right(int k, int dir)
            {
                if (k > 3) return;
                if (gear[k][6] != gear[k - 1][2])
                {
                    Right(k + 1, -dir);       
                    Rotate(k, dir);
                }            
            }

            void Left(int k, int dir)
            {
                if (k < 0) return;
                if (gear[k][2] != gear[k + 1][6])
                {
                    Left(k - 1, -dir);
                    Rotate(k, dir);
                }          
            }

            void Rotate(int k, int dir)
            {
                if (dir == 1)
                {
                    gear[k].Insert(0, gear[k][7]);
                    gear[k].RemoveAt(8);
                }
                else
                {
                    gear[k].Add(gear[k][0]);
                    gear[k].RemoveAt(0);
                }
            }
        } 
    }
}
