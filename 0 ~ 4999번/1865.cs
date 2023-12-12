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
            int n, m, w, INF = 987654321;
            List<(int, int, int)> node = new List<(int, int, int)>();
            int tc = int.Parse(Console.ReadLine());
            while (tc-- > 0)
            {
                node.Clear();
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                n = input[0];
                m = input[1];
                w = input[2];

                for (int i = 0; i < m; i++)
                {
                    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    int s = input[0], e = input[1], t = input[2];

                    node.Add((s, e, t));
                    node.Add((e, s, t));
                }

                for (int i = 0; i < w; i++)
                {
                    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    int s = input[0], e = input[1], t = input[2];

                    node.Add((s, e, -t));
                }

                Console.WriteLine(Bellman() ? "YES" : "NO");
            }

            bool Bellman()
            {
                var d = new int[n + 1];
                var u = false;

                for (int i = 1; i < n + 1; i++)
                    d[i] = INF;

                d[1] = 0;

                for (int i = 1; i < n; i++)
                {
                    u = false;
                    foreach ((int s, int e, int t) in node)
                    {                       
                        if (d[e] > d[s] + t)
                        {
                            d[e] = d[s] + t;
                            u = true;
                        }
                    }

                    if (!u) break;
                }

                if (u)
                {
                    for (int j = 1; j < n + 1; j++)
                    {
                        foreach ((int s, int e, int t) in node)
                            if (d[e] > d[s] + t)
                                return true;
                    }
                }

                return false;
            }
        }

    }
}