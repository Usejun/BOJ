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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1], k = input[2];
            var map = new int[n, m];
            var visit = new bool[n, m];
            var dx = new int[] { 0, 0, 1, -1 };
            var dy = new int[] { 1, -1, 0, 0 };
            int max = 0;
            int count = 0;

            for (int i = 0; i < k; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                map[input[0] - 1, input[1] - 1] = 1;
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (map[i, j] == 1 && !visit[i, j])
                    {
                        count = 0;
                        Dfs(i, j);
                        max = Math.Max(max, count);
                    }

            Console.WriteLine(max);

            void Dfs(int x, int y)
            {
                count++;
                visit[x, y] = true;

                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    if (nx < 0 || nx >= n || ny < 0 || ny >= m || map[nx, ny] != 1 || visit[nx, ny])
                        continue;

                    Dfs(nx, ny);
                }
            }
        }
    }
}
