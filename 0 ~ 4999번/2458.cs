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
            int n = input[0], m = input[1], INF = 1000;
            var student = new bool[n, n];

            for (int i = 0; i < n; i++)        
                for (int j = 0; j < n; j++)
                    if (i == j) student[i, j] = true;
                        
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = input[0] - 1, b = input[1] - 1;

                student[a, b] = true; 
            }

            for (int k = 0; k < n; k++)
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (student[i, k] && student[k, j])
                            student[i, j] = true;

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                count++;
                for (int j = 0; j < n; j++)
                {
                    if (!student[i, j] && !student[j, i])
                    {
                        count--;
                        break;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}