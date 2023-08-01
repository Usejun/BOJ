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
            var map = new int[n][];
            var visit = new bool[n,m];
            var dx = new int[] { 0, 0, 1, -1 };
            var dy = new int[] { 1, -1, 0, 0 };
            int max = 0;
            for (int i = 0; i < n; i++)
                map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++) 
                {
                    visit[i, j] = true;
                    dfs(j, i, map[i][j], 1);
                    visit[i, j] = false;
                }

            Console.WriteLine(max);

            void dfs(int x, int y, int sum, int count)
            {
                if (count == 4)
                {
                    max = Math.Max(max, sum);
                    return;
                }

                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    if (nx < 0 || nx >= m || ny < 0 || ny >= n || visit[ny, nx])
                        continue;

                    if (count == 2)
                    {
                        visit[ny, nx] = true;
                        dfs(x, y, sum + map[ny][nx], count + 1);
                        visit[ny, nx] = false;
                    }

                    visit[ny, nx] = true;
                    dfs(nx, ny, sum + map[ny][nx], count + 1);
                    visit[ny, nx] = false;
                                      
                }
            }
        }
    }
}
    
