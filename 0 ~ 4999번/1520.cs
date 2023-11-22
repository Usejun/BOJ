using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var dx = new int[] { 0, 0, 1, -1 };
            var dy = new int[] { 1, -1, 0, 0 };
            var dp = new int[n, m];
            var route = new int[n][];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    dp[i, j] = -1;

            for (int i = 0; i < n; i++)
                route[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(Dfs(0, 0));

            int Dfs(int x, int y)
            {
                if (x == n - 1 && y == m - 1)
                    return 1;

                if (dp[x, y] != -1)
                    return dp[x, y];

                dp[x, y] = 0;
                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    if (nx < 0 || nx >= n || ny < 0 || ny >= m || route[x][y] <= route[nx][ny])
                        continue;

                    dp[x, y] += Dfs(nx, ny);
                }

                return dp[x, y];
            }
            
        }
    }
}