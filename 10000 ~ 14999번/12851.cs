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
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0], m = input[1], max = 100001;
        var q = new Queue<(int x, int c)>();
        var visit = Enumerable.Repeat(int.MaxValue, max).ToArray();
        var count = new List<int>();    

        q.Enqueue((n, 0));

        while (q.Any())
        {
            (int x, int c) = q.Dequeue();

            if (x == m)
                count.Add(c);

            if (x - 1 >= 0 && visit[x - 1] >= c)
            {
                visit[x - 1] = c;
                q.Enqueue((x - 1, c + 1));
            }
            if (x + 1 < max && visit[x + 1] >= c)
            {
                visit[x + 1] = c;
                q.Enqueue((x + 1, c + 1));
            }
            if (2 * x < max && visit[2 * x] >= c)
            {
                visit[2 * x] = c;
                q.Enqueue((2 * x, c + 1));
            }
        }

        Console.WriteLine(count.Min());
        Console.WriteLine(count.Count(i => i == count.Min()));
    }
}