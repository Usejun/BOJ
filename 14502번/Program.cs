using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var dx = new int[] { 0, 0, 1, -1, };
            var dy = new int[] { 1, -1, 0, 0, };
            var map = new int[n][];
            var visited = new bool[n, m];
            int result = 0;
            for (int i = 0; i < n; i++)
                map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (map[i][j] != 0)
                        continue;
                    else
                    {
                        SetWall(j, i, 0);
                        map[i][j]--;
                    }

            Console.WriteLine(result);

            void SetWall(int x, int y, int depth)
            {
                map[y][x]++;
                if (depth == 2)
                {
                    FillMap();
                    return;
                }

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (map[i][j] != 0)
                            continue;
                        else
                        {
                            SetWall(j, i, depth + 1);
                            map[i][j]--;
                        }

            }

            void FillMap()
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (map[i][j] == 2 && !visited[i, j])
                            Dfs(j, i);

                Count();
                visited = new bool[n, m];
            }

            void Dfs(int x, int y)
            {
                if (x < 0 || x >= m || y < 0 || y >= n || visited[y, x] || map[y][x] == 1)
                    return;

                visited[y, x] = true;

                for (int i = 0; i < 4; i++)
                    Dfs(x + dx[i], y + dy[i]);
            }

            void Count()
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (!visited[i, j] && map[i][j] != 1)
                            sum++;

                result = Math.Max(sum, result);
            }
        }
    }
}
    
