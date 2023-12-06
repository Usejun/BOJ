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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var map = new string[n];
            var visit = new bool[n, m];
            int count = 0;

            for (int i = 0; i < n; i++)            
                map[i] = Console.ReadLine();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (!visit[i, j])
                    {
                        count++;
                        DFS(i, j, map[i][j]);
                    }

            Console.WriteLine(count);

            void DFS(int x, int y, char c)
            {
                if (map[x][y] != c) return;
                visit[x, y] = true;

                if (c == '-' && y < m - 1) y++;
                else if (c == '|' && x < n - 1) x++;

                if (!visit[x, y]) DFS(x, y, c);
            }
        }
    }
}
