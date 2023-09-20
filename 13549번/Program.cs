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
            var visit = new bool[100001];
            var q = new Queue<(int, int)>();
            int answer = int.MaxValue;

            visit[n] = true;
            q.Enqueue((n, 0));

            while (q.Any())
            {
                (int p, int t) = q.Dequeue();

                if (p == m)
                {
                    answer = Math.Min(answer, t);
                    continue;
                }

                if (p * 2 <= 100000 && !visit[p * 2])
                {
                    visit[p * 2] = true;
                    q.Enqueue((p * 2, t));
                }

                if (p > 0 && !visit[p - 1])
                {
                    visit[p - 1] = true;
                    q.Enqueue((p - 1, t + 1));
                }

                if (p < 100000 && !visit[p + 1])
                {
                    visit[p  + 1] = true;
                    q.Enqueue((p + 1, t + 1));
                }
            }

            Console.WriteLine(answer);
        }
    }
}
