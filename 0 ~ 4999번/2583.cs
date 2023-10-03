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
            var dx = new int[] { 0, 0, 1, -1 };
            var dy = new int[] { 1, -1, 0, 0 };
            int n = input[0], m = input[1], k = input[2];
            int count = 0;
            var map = new bool[n, m];
            var answer = new List<int>();

            for (int i = 0; i < k; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x1 = input[0], y1 = input[1], x2 = input[2], y2 = input[3];

                for (int j = y1; j < y2; j++)
                    for (int q = x1; q < x2; q++)
                        map[j, q] = true;                    
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (!map[i, j])
                    {
                        count = 0;
                        Dfs(j, i);
                        answer.Add(count);
                    }

            Console.WriteLine(answer.Count + "\n" + string.Join(" ", answer.OrderBy(i => i)));

            void Dfs(int x, int y)
            {
                count++;
                map[y, x] = true;

                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    if (nx < 0 || nx >= m || ny < 0 || ny >= n || map[ny, nx]) continue;             

                    Dfs(nx, ny);         
                }
            }
        }
    }
}