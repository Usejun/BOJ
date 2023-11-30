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
            int t = int.Parse(Console.ReadLine());
            List<int>[] graph;
            int s = 0, e = -1;

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                graph = new List<int>[n + 2];

                for (int i = 0; i < n + 2; i++) 
                    graph[i] = new List<int>();                

                var points = new List<(int x, int y)>();
                var start = Console.ReadLine().Split().Select(int.Parse).ToArray();
                points.Add((start[0], start[1]));
                for (int i = 0; i < n; i++)
                {
                    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    points.Add((input[0], input[1]));
                }
                var end = Console.ReadLine().Split().Select(int.Parse).ToArray();
                points.Add((end[0], end[1]));

                e = n + 1;

                for (int i = 0; i < n + 2; i++)
                    for (int j = 0; j < n + 2; j++)
                        if (i != j && Check(points[i], points[j]))
                            graph[i].Add(j);

                Console.WriteLine(BFS() ? "happy" : "sad");
            }

            bool BFS()
            {
                var q = new Queue<int>();
                var visit = new bool[graph.Length];
                q.Enqueue(s);

                while (q.Any())
                {
                    int n = q.Dequeue();

                    if (n == e) return true;

                    foreach (var i in graph[n])
                    {
                        if (!visit[i])
                        {
                            visit[i] = true;
                            q.Enqueue(i);
                        }
                    }
                }

                return false;
            }

            bool Check((int x, int y) p1, (int x, int y) p2)
            {
                return Math.Abs(p1.x - p2.x) + Math.Abs(p1.y - p2.y) <= 1000;
            }
        }
    }
}