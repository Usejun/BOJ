using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var dx = new int[] { 0, 0, 1, -1 };
            var dy = new int[] { 1, -1, 0, 0 };
            var board = new int[n][];
            var visit = new bool[n, m];
            int size = 0;
            int count = 0, max = 0;                     

            for (int i = 0; i < n; i++)
                board[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (!visit[i, j] && board[i][j] == 1)
                    {
                        size = 0;
                        count++;
                        Dfs(j, i);
                        max = max > size ? max : size;
                    }

            Console.WriteLine(count);
            Console.WriteLine(max);

            void Dfs(int x, int y)
            {
                visit[y, x] = true;
                size++;

                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    if (nx >= 0 && nx < m && ny >= 0 && ny < n && !visit[ny, nx] && board[ny][nx] == 1)
                    {
                        Dfs(nx, ny);
                    }
                }
            }
        }
    }
}
    
