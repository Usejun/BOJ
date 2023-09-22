using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Boj
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            var sb = new StringBuilder();
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = size[0], m = size[1];
            var maps = new int[n, m];
            var visited = new bool[n, m];
            var q = new Queue<(int, int, int)>();
            int sx = 0, sy = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    if (input[j] == 2)
                    {
                        sx = j;
                        sy = i;
                    }
                    maps[i, j] = input[j];
                }
            }

            q.Enqueue((sx, sy, 0));

            while (q.Count != 0)
            {
                (int x, int y, int count) = q.Dequeue();
 
                if (x < 0 || y < 0 || x >= m || y >= n || visited[y, x] || maps[y, x] == 0)
                    continue;

                visited[y, x] = true;
                maps[y, x] = count;               
                 
                q.Enqueue((x - 1, y, count + 1));
                q.Enqueue((x, y - 1, count + 1));
                q.Enqueue((x + 1, y, count + 1));
                q.Enqueue((x, y + 1, count + 1));
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    sb.Append(maps[i, j] == 1 && !visited[i, j] ? -1 + " " : maps[i, j] + " ");
                sb.Append('\n');
            }

            Console.WriteLine(sb);
        }
    }
}
