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
            StringBuilder sb = new StringBuilder();
            int[] input;
            int n, m;
            int[][] map;
            bool[,] visit;
            int[] dx = { 1, -1, 0, 0, 1, 1, -1, -1 };
            int[] dy = { 0, 0, 1, -1, 1, -1, 1, -1 };

            while(true)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                m = input[0];
                n = input[1];
                int count = 0;
                
                if (n == 0 || m == 0)
                    break;
              
                map = new int[n][];
                visit = new bool[n, m];

                for (int i = 0; i < n; i++)
                    map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int i = 0; i < n; i++)                
                    for (int j = 0; j < m; j++)
                        if (map[i][j] == 1 && !visit[i,j])
                        {
                            Dfs(j, i);
                            count++;
                        }

                sb.Append(count + "\n");
            }

            Console.WriteLine(sb);

            void Dfs(int x, int y)
            {
                if (x < 0 || x >= m || y < 0 || y >= n || map[y][x] == 0 || visit[y, x])
                    return;

                visit[y, x] = true;

                for (int i = 0; i < 8; i++)
                {
                    int nextX = x + dx[i];
                    int nextY = y + dy[i];

                    if (nextX < 0 || nextX >= m || nextY < 0 || nextY >= n || map[nextY][nextX] == 0 && visit[nextY, nextX])
                        continue;

                    Dfs(nextX, nextY);

                }
            }

        }
    }
}
