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
            int n = input[0], m = input[1];
            var map = new string[n];

            for (int i = 0; i < n; i++)            
                map[i] = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                var arr = Enumerable.Repeat(-1, m).ToArray();

                for (int j = 0; j < m; j++)
                    if (map[i][j] == 'c') 
                        arr[j] = 0;                   
                    else if (j > 0 && arr[j] == -1 && arr[j - 1] != -1)
                        arr[j] = arr[j - 1] + 1;                                                          
                
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
