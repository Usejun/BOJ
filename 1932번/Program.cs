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
            int n = int.Parse(Console.ReadLine());
            var array = new int[n][];
            var sum = new int[n, n];
            int result = 0;
            for (int i = 0; i < n; i++)
                array[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            sum[0, 0] = array[0][0];

            for (int i = 1; i < n; i++)
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j == 0)
                        sum[i, j] = sum[i - 1, j] + array[i][j];
                    else
                        sum[i, j] = Math.Max(sum[i - 1, j - 1], sum[i - 1, j]) + array[i][j];
                }

            for (int i = 0; i < n; i++)
                result = result < sum[n - 1, i] ? sum[n - 1, i] : result;

            Console.WriteLine(result);       
        }       
    }
}
    
