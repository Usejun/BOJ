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
            int f = input[0], s = input[1], g = input[2], u = input[3], d = input[4];
            var q = new Queue<(int, int)>();
            var visit = new bool[f + 1];
            int min = int.MaxValue;

            q.Enqueue((s, 0));

            while (q.Any())
            {
                (int floor, int count) = q.Dequeue();

                if (floor == g)                
                    min = min < count ? min : count;

                if (floor + u <= f && !visit[floor + u])
                {
                    q.Enqueue((floor + u, count + 1));
                    visit[floor + u] = true;
                }
                if (floor - d > 0 && !visit[floor - d])
                {
                    q.Enqueue((floor - d, count + 1));
                    visit[floor - d] = true;
                }
            }

            Console.WriteLine(min == int.MaxValue ? "use the stairs" : $"{min}");

        }
    }
}