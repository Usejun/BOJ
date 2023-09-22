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
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = input[0], n = input[1], h = input[2];
            var box = new int[h, n, m];
            var days = new int[h, n, m];
            var q = new Queue<(int, int, int)>();
            var dx = new int[] { 0, 0, 1, -1, 0, 0 };
            var dy = new int[] { 1, -1, 0, 0, 0, 0 };
            var dz = new int[] { 0, 0, 0, 0, 1, -1 };
            int max = 0;

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int k = 0; k < m; k++)
                    {
                        box[i, j, k] = input[k];
                        if (input[k] == 1)
                            q.Enqueue((k, j, i));
                        if (input[k] == 0)
                            days[i, j, k] = -1;
                    }
                }
            }

            while (q.Count != 0)
            {
                (int x, int y, int z) = q.Dequeue();

                for (int i = 0; i < 6; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];
                    int nz = z + dz[i];

                    if (nx < 0 || nx >= m || ny < 0 || ny >= n || nz < 0 || nz >= h ||
                        box[nz, ny, nx] == -1 || days[nz, ny, nx] >= 0)
                        continue;
                    if (box[nz, ny, nx] == 0)
                    {
                        days[nz, ny, nx] = days[z, y, x] + 1;
                        q.Enqueue((x + dx[i], y + dy[i], z + dz[i]));
                        continue;
                    }
                    if (box[nz, ny, nx] == 1)
                    {
                        days[nz, ny, nx] = days[z, y, x];
                        q.Enqueue((x + dx[i], y + dy[i], z + dz[i]));
                    }
                }
            }

            for (int i = 0; i < h; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < m; k++)
                    {
                        if (days[i, j, k] == -1)
                        {
                            Console.WriteLine(-1);
                            return;
                        }
                        max = Math.Max(max, days[i, j, k]);
                    }

            Console.WriteLine(max);
        }
    }
}
    
