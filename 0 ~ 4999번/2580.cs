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
            var map = new int[9, 9];
            int count = 0;  

            for (int i = 0; i < 9; i++)
            {
                var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < 9; j++)
                {
                    map[i, j] = row[j];
                    count = row[j] == 0 ? count + 1 : count;
                }
            }

            Go(0);            

            (int, int) Next()
            {
                for (int i = 0; i < 9; i++)
                    for (int j = 0; j < 9; j++)
                        if (map[i, j] == 0)
                            return (i, j);
                return (-1, -1);
            }

            bool Check(int x, int y, int value)
            {
                for (int i = 0; i < 9; i++)                
                    if (map[x, i] == value || map[i, y] == value)
                        return false;

                int tx = (x / 3) * 3;
                int ty = (y / 3) * 3;

                for (int i = tx; i < tx + 3; i++)
                    for (int j = ty; j < ty + 3; j++)
                        if (map[i, j] == value)
                            return false;

                return true;
            } 

            void Go(int depth)
            {               
                if (depth == count)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                            Console.Write(map[i, j] + " ");
                        Console.WriteLine();
                    }
                    Environment.Exit(0);
                }

                (int x, int y) = Next();

                for (int k = 1; k <= 9; k++)
                {
                    if (Check(x, y, k))
                    {
                        map[x, y] = k;
                        Go(depth + 1);
                    }
                    map[x, y] = 0;
                }
            }
        }
    }
}