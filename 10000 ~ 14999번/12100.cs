using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var board = new int[n][];
            int max = 0;

            for (int i = 0; i < n; i++)
                board[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Move(board, 0);

            Console.WriteLine(max);

            void Move(int[][] copy, int depth)
            {
                if (depth == 5)
                {
                    for (int i = 0; i < n; i++)
                        max = Math.Max(max, copy[i].Max());
                    return;
                }

                Move(Up(Copy(copy)), depth + 1);
                Move(Down(Copy(copy)), depth + 1);
                Move(Left(Copy(copy)), depth + 1);
                Move(Right(Copy(copy)), depth + 1);
            }

            int[][] Up(int[][] copy)
            {
                var merged = new bool[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i < 1) break;
                        if (copy[i][j] == 0) continue;

                        if (!merged[i, j] && !merged[i - 1, j] && copy[i - 1][j] == copy[i][j])
                        {
                            copy[i - 1][j] <<= 1;
                            copy[i][j] = 0;
                            merged[i - 1, j] = true;
                            i--;
                            j--;
                            break;
                        }
                        else if (copy[i - 1][j] == 0)
                        {
                            copy[i - 1][j] = copy[i][j];
                            copy[i][j] = 0;
                            merged[i - 1, j] = false;
                            i -= 2;
                            j--;
                            break;
                        }
                    }
                }

                return copy;
            }

            int[][] Down(int[][] copy)
            {
                var merged = new bool[n, n];

                for (int i = n - 1; i >= 0; i--)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i >= n - 1) break;
                        if (copy[i][j] == 0) continue;

                        if (!merged[i, j] && !merged[i + 1, j] && copy[i + 1][j] == copy[i][j])
                        {
                            copy[i + 1][j] <<= 1;
                            copy[i][j] = 0;
                            merged[i + 1, j] = true;
                            i++;
                            j--;
                            break;
                        }
                        else if (copy[i + 1][j] == 0)
                        {
                            copy[i + 1][j] = copy[i][j];
                            copy[i][j] = 0;
                            merged[i + 1, j] = false;
                            i += 2;
                            j--;
                            break;
                        }
                    }
                }

                return copy;
            }

            int[][] Right(int[][] copy)
            {
                var merged = new bool[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i < 1) break;
                        if (copy[j][i] == 0) continue;

                        if (!merged[j, i] && !merged[j, i - 1] && copy[j][i - 1] == copy[j][i])
                        {
                            copy[j][i - 1] <<= 1;
                            copy[j][i] = 0;
                            merged[j, i - 1] = true;
                            i--;
                            j--;
                            break;
                        }
                        else if (copy[j][i - 1] == 0)
                        {
                            copy[j][i - 1] = copy[j][i];
                            copy[j][i] = 0;
                            merged[j, i - 1] = false;
                            i -= 2;
                            j--;
                            break;
                        }
                    }
                }

                return copy;
            }

            int[][] Left(int[][] copy)
            {
                var merged = new bool[n, n];

                for (int i = n - 1; i >= 0; i--)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i >= n - 1) break;
                        if (copy[j][i] == 0) continue;

                        if (!merged[j, i] && !merged[j, i + 1] && copy[j][i + 1] == copy[j][i])
                        {
                            copy[j][i + 1] <<= 1;
                            copy[j][i] = 0;
                            merged[j, i + 1] = true;
                            i++;
                            j--;
                            break;
                        }
                        else if (copy[j][i + 1] == 0)
                        {
                            copy[j][i + 1] = copy[j][i];
                            copy[j][i] = 0;
                            merged[j, i + 1] = false;
                            i += 2;
                            j--;
                            break;
                        }
                    }
                }

                return copy;
            }

            int[][] Copy(int[][] original)
            {
                var copy = new int[n][];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        copy[i] = original[i].ToArray();
                        
                return copy;       
            }
        }
    }
}