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
            var map = new char[n][];
            int max = 0;

            for (int i = 0; i < n; i++)
                map[i] = Console.ReadLine().ToCharArray();

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                     if (map[i][j] != map[i][j - 1])
                    {
                        (map[i][j], map[i][j - 1]) = (map[i][j - 1], map[i][j]);
                        Check();
                        (map[i][j], map[i][j - 1]) = (map[i][j - 1], map[i][j]);
                    }
                    if (map[j][i] != map[j - 1][i])
                    {
                        (map[j][i], map[j - 1][i]) = (map[j - 1][i], map[j][i]);
                        Check();
                        (map[j][i], map[j - 1][i]) = (map[j - 1][i], map[j][i]);
                    }
                }
            }

            Console.WriteLine(max);

            void Check()
            {
                for (int i = 0; i < n; i++)
                {
                    int count = 1;
                    for (int j = 1; j < n; j++)
                    {
                        count = map[i][j] == map[i][j - 1] ? count + 1 : 1;
                        max = Math.Max(max, count);
                    }

                    count = 1;
                    for (int j = 1; j < n; j++)
                    {
                        count = map[j][i] == map[j - 1][i] ? count + 1 : 1;
                        max = Math.Max(max, count);
                    }
                }
            }
        }
    }
}