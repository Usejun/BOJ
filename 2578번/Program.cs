using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            var board = new int[5, 5];
            var numbers = new int[25];
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < 5; j++)
                    board[i, j] = input[j];
            }
            for (int i = 0; i < 5; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < 5; j++)
                    numbers[i * 5 + j] = input[j];
            }

            while (true)
            {
                int line = 0;
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        if (board[i, j] == numbers[count])
                            board[i, j] = 0;


                for (int i = 0; i < 5; i++)
                {
                    int rowSum = 0;
                    int colSum = 0;

                    for (int j = 0; j < 5; j++)
                    {
                        rowSum += board[i, j];
                        colSum += board[j, i];
                    }

                    if (rowSum == 0)
                        line++;
                    if (colSum == 0)
                        line++;
                }

                int rowDiagonal = 0;
                int colDiagonal = 0;

                for (int i = 0; i < 5; i++)
                {
                    rowDiagonal += board[i, i];
                    colDiagonal += board[i, 4 - i];
                }

                if (rowDiagonal == 0)
                    line++;
                if (colDiagonal == 0)
                    line++;

                if (line >= 3)
                    break;

                count++;
            }

            Console.WriteLine(count + 1);
        }
    }
}
    
