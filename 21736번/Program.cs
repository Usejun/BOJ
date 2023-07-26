using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var dx = new int[] { 0, 0, 1, -1 };
            var dy = new int[] { 1, -1, 0, 0 };
            var map = new char[n][];
            var vistied = new bool[n, m];
            int count = 0;

            for (int i = 0; i < n; i++)
                map[i] = Console.ReadLine().ToCharArray();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (map[i][j] == 'I')
                        Dfs(j, i);

            Console.WriteLine(count == 0 ? "TT" : $"{count}");

            void Dfs(int x, int y)
            {
                if (x < 0 || x >= m || y < 0 || y >= n || vistied[y, x] || map[y][x] == 'X')
                    return;

                vistied[y, x] = true;
                if (map[y][x] == 'P')
                    count++;

                for (int i = 0; i < 4; i++)                
                    Dfs(x + dx[i], y + dy[i]);                                
            }
            
            
        }
    }
}
    
