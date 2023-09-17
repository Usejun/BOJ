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
        static void Main(string[] args)            
        {
            int n = int.Parse(Console.ReadLine());
            var rgb = new string[n];
            var vis = new bool[n,n];
            int[] dirX = { 0, 0, 1, -1 };
            int[] dirY = { -1, 1, 0, 0 };
            int red = 0, redGreen = 0;

            for (int i = 0; i < n; i++)
                rgb[i] = Console.ReadLine();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (vis[i, j])
                        continue;

                    Find(j, i, rgb[i][j]);
                    red++;
                }

            vis = new bool[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (vis[i, j])
                        continue;
                    if (rgb[i][j] == 'B')
                        Find(j, i, 'B');
                    else
                        Find(j, i, 'G', 'R');
                    redGreen++;
                }

            Console.WriteLine($"{red} {redGreen}");

            void Find(int x, int y, params char[] color)
            {
                if (x < 0 || y < 0 || x >= n || y >= n || vis[y, x] || !color.Contains(rgb[y][x]))                
                    return;

                vis[y, x] = true;

                for (int i = 0; i < 4; i++)
                    Find(x + dirX[i], y + dirY[i], color);              
            }           
        }
    }
}
    
