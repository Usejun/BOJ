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
            int n = input[0], m = input[1], max = 0;
            var dx = new int[] { 1, -1, 0, 0 };
            var dy = new int[] { 0, 0, -1, 1 };
            var map = new string[n];
            var set = new HashSet<char>();

            for (int i = 0; i < n; i++)            
                map[i] = Console.ReadLine();

            set.Add(map[0][0]);
            Dfs(0, 0, 1);

            Console.WriteLine(max);

            void Dfs(int x, int y, int length)
            {
                max = Math.Max(max, length);

                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    if (nx >= 0 && nx < m && ny >= 0 && ny < n && !set.Contains(map[ny][nx]))
                    {
                        set.Add(map[ny][nx]);
                        Dfs(nx, ny, length + 1);
                        set.Remove(map[ny][nx]);
                    }
                }
            }
        }
    }
}