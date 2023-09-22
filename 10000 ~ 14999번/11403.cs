using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var graph = new int[n][];
            var visit = new bool[n, n];

            for (int i = 0; i < n; i++)
                graph[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (graph[i][j] == 1)
                        Dfs(i, j);          

            for (int i = 0; i < n; i++)
                Console.WriteLine(string.Join(" ", graph[i]));

            void Dfs(int start, int x)
            {
                graph[start][x] = 1;
                visit[start, x] = true;

                for (int i = 0; i < n; i++)
                    if (graph[x][i] == 1 && !visit[start, i])
                        Dfs(start, i);  
            }           
        }
    }
}
