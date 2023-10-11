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
            int n = int.Parse(Console.ReadLine());
            var dp = Enumerable.Repeat(1000001, 1000001).ToArray();
            var root = Enumerable.Repeat(1000001, 1000001).ToArray();
            var q = new Queue<int>();

            dp[1] = 0;
            root[1] = -1;

            q.Enqueue(1);

            while (q.Any())
            {
                int now = q.Dequeue();
                int next = now;

                if (next == n)
                    continue;

                for (int i = 0; i < 3; i++)
                {
                    if (i == 0) next = now * 3;
                    if (i == 1) next = now * 2;
                    if (i == 2) next = now + 1;

                    if (next <= n && dp[next] > dp[now] + 1)
                    {
                        dp[next] = dp[now] + 1;
                        root[next] = now; 
                        q.Enqueue(next);
                    }
                }
            }

            Console.WriteLine(dp[n]);

            while (n != -1)
            {
                Console.Write(n);
                Console.Write(" ");
                n = root[n];
            }
        }
    }
}