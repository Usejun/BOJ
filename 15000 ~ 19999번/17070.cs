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
            int n = int.Parse(Console.ReadLine());
            int means = 0;
            var map = new int[n][];

            for (int i = 0; i < n; i++)            
                map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dfs(1, 0, 0);

            Console.WriteLine(means);

            // dir, 0 = 가로, 1 = 세로, 2 = 대각선
            void Dfs(int x, int y, int dir)
            {
                if (x + 1 == n && y + 1 == n)
                {
                    means++;
                    return;
                }

                if (dir == 0)
                {
                    if (x + 1 < n && map[y][x + 1] != 1) Dfs(x + 1, y, 0);
                    if (x + 1 < n && y + 1 < n && map[y + 1][x + 1] != 1 
                    && map[y][x + 1] != 1 && map[y + 1][x] != 1)
                        Dfs(x + 1, y + 1, 2);
                }
                else if (dir == 1)
                {
                    if (y + 1 < n && map[y + 1][x] != 1) Dfs(x, y + 1, 1);
                    if (x + 1 < n && y + 1 < n && map[y + 1][x + 1] != 1
                    && map[y][x + 1] != 1 && map[y + 1][x] != 1)
                        Dfs(x + 1, y + 1, 2);
                }
                else if (dir == 2)
                {
                    if (x + 1 < n && map[y][x + 1] != 1) Dfs(x + 1, y, 0);
                    if (y + 1 < n && map[y + 1][x] != 1) Dfs(x, y + 1, 1);
                    if (x + 1 < n && y + 1 < n && map[y + 1][x + 1] != 1
                        && map[y][x + 1] != 1 && map[y + 1][x] != 1)
                        Dfs(x + 1, y + 1, 2);
                }
            }
        }
    }
}
