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
            int r1 = input[0];
            int c1 = input[1];
            int r2 = input[2];
            int c2 = input[3];
            int max = 0;
            var board = new int[50, 50];

            for (int i = r1; i <= r2; i++)
            {
                for (int j = c1; j <= c2; j++)
                {
                    int r = i - r1;
                    int c = j - c1;

                    if (i > j)
                        if (i + j > 0)
                            board[r, c] = (i * 2 + 1) * (i * 2 + 1) - i + j;
                        else
                            board[r, c] = (j * 2) * (j * 2) - j + 1 + i;
                    else if (i == j)
                        if (i >= 0)
                            board[r, c] = (i * 2 + 1) * (i * 2 + 1);
                        else
                            board[r, c] = (i * -2) * (i * -2) + 1;
                    else 
                        if (i + j < 0)
                            board[r, c] = (i * 2) * (i * 2) + i - j + 1;
                        else
                            board[r, c] = (j * 2 - 1) * (j * 2 - 1) + j - i;

                    max = max < board[r, c] ? board[r, c] : max;
                }                
            }

            int length = max.ToString().Length;
            for (int i = r1; i <= r2; i++)
            {
                for (int j = c1; j <= c2; j++)
                {
                    int r = i - r1;
                    int c = j - c1;

                    if (j == c2)                    
                        Console.WriteLine(new string(' ', length - board[r, c].ToString().Length) + board[r, c]);
                    else
                        Console.Write(new string(' ', length - board[r, c].ToString().Length) + board[r, c] + " ");
                }   
            }
        }
    }
}
