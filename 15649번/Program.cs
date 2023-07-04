using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Boj
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0], M = input[1];
            var visited = new bool[N];
            var array = new int[M];

            dfs(N, M, 0);

            void dfs(int n, int m, int depth)
            {
                if (depth == M)
                {
                    Console.WriteLine(string.Join(" ", array));
                    return;
                }

                for (int i = 0; i < N; i++)
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        array[depth] = i + 1;
                        dfs(n, m, depth + 1);
                        visited[i] = false;
                    }
                }
                return;
            }
        }
    }
}
    
