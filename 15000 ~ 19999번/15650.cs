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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0], M = input[1];
            var array = new int[M];
            var visited = new bool[N];

            dfs(0, 0);

            void dfs(int start, int depth)
            {
                if (depth == M)
                {
                    Console.WriteLine(string.Join(" ", array));
                    return;
                }

                for (int i = start; i < N; i++)
                {
                    if (!visited[i])
                    {
                        array[depth] = i + 1;
                        visited[i] = true;
                        dfs(i + 1, depth + 1);
                        visited[i] = false;
                    }
                }
            }
            
        }
    }
}
