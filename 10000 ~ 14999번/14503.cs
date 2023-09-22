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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int r = input[0], c = input[1], d = input[2];
            var map = new int[n][];
            var dx = new int[] { 0, 1, 0, -1 };
            var dy = new int[] { -1, 0, 1, 0 };

            for (int i = 0; i < n; i++)            
                map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                map[r][c] = 2;

                if (Check(c, r))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        d = d == 0 ? 3 : d - 1;

                        if (map[r + dy[d]][c + dx[d]] == 0)
                        {
                            c += dx[d];
                            r += dy[d];
                            break;
                        }
                    }
                }
                else
                {
                    if (map[r - dy[d]][c - dx[d]] != 1)
                    {
                        c -= dx[d];
                        r -= dy[d];
                    }
                    else break;                    
                }
            }

            int count = 0;

            for (int i = 0; i < n; i++)
                count += map[i].Count(x => x == 2);

            Console.WriteLine(count);

            bool Check(int x, int y)
            {
                for (int i = 0; i < 4; i++)                
                    if (map[y + dy[i]][x + dx[i]] == 0)
                        return true;
                return false;                                
            }
        }
    }
}
