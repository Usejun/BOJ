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
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long n = input[0], m = input[1], MOD = 1000;
        var source = new long[n, n];       

        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            for (int j = 0; j < n; j++)
                source[i, j] = input[j];
        }

        long[,] result = Power(source, m);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(result[i, j] % MOD + " ");
            Console.WriteLine();
        }

        long[,] Multiply(long[,] matrix1, long[,] matrix2)
        {
            long[,] result = new long[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)   
                    for (int k = 0; k < n; k++)
                        result[i, j] += matrix1[i, k] * matrix2[k, j] % MOD;
                
            return result;
        }

        long[,] Power(long[,] matrix, long count)
        {
            if (count == 0)
            {
                long[,] zeroPower = new long[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)                       
                        zeroPower[i, j] = i == j ? 1 : 0;
                return zeroPower;
            }

            var x = Power(matrix, count/2);

            if (count % 2 == 0)
                return Multiply(x, x);
            else
                return Multiply(matrix, Multiply(x, x));
        }
    }
}