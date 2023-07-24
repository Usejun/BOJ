using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace CodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var map = new int[n][];
            var visited = new bool[n,n];
            var dx = new int[] { 0, 0, 1, -1 };
            var dy = new int[] { 1, -1, 0, 0 };
            int max = -1;

            for (int i = 0; i < n; i++)            
                map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < 100; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                        if (map[j][k] > i && !visited[j,k])
                        {
                            Dfs(k, j, i);
                            count++;
                        }

                max = Math.Max(max, count);
                visited = new bool[n, n]; 
            }
                    
            Console.WriteLine(max);

            void Dfs(int x, int y, int height)
            {
                if (x < 0 || x >= n || y < 0 || y >= n || visited[y, x] || map[y][x] <= height)
                    return;

                visited[y, x] = true;

                for (int i = 0; i < 4; i++)
                    Dfs(x + dx[i], y + dy[i], height);               
            }
        }
    }
}   
