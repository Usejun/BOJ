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
            var video = new string[n];
            var answer = "";

            for (int i = 0; i < n; i++)
                video[i] = Console.ReadLine();
          
            Compress(0, 0, n);

            Console.Write(answer);

            void Compress(int x, int y, int length)
            {
                bool equal = true;

                for (int i = 0; i < length && equal; i++)
                    for (int j = 0; j < length && equal; j++)
                        if (video[y + i][x + j] != video[y][x])
                            equal = false;

                if (equal)
                    answer += video[y][x];
                else
                {
                    answer += "(";
                    Compress(x, y, length / 2);
                    Compress(x + length / 2, y, length / 2);
                    Compress(x, y + length / 2, length / 2);
                    Compress(x + length / 2, y + length / 2, length / 2);
                    answer += ")";
                }
            }
        }
    }
}
