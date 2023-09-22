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
            var map = new int[101];
            var visit = new int[101];
            var q = new Queue<int>();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];

            for (int i = 0; i < n + m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                map[input[0]] = input[1];
            }

            for (int i = 0; i < 101; i++)
                visit[i] = int.MaxValue;

            visit[1] = 0;
            q.Enqueue(1);

            while (q.Any())
            {
                int num = q.Dequeue();

                if (num == 100) continue;

                for (int i = 1; i <= 6; i++)
                {
                    if (num + i > 100) break;

                    int nn = map[num + i] != 0 ? map[num + i] : num + i;

                    if (visit[nn] > visit[num] + 1)
                    {
                        visit[nn] = visit[num] + 1;
                        q.Enqueue(nn);
                    }
                }                    
            }

            Console.WriteLine(visit[100]);
        }
    }
}
