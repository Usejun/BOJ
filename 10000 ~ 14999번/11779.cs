using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] input;
            var bus = new List<(int t, int v)>[1001];
            var pq = new PriorityQueue<(int t, int v), int>();
            for (int i = 0; i < 1001; i++)        
                bus[i] = new List<(int t, int v)>();        

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                bus[input[0]].Add((input[1], input[2]));
            }

            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = input[0], end = input[1];
            var d = Enumerable.Repeat(987654321, 1001).ToArray();
            var connect = new int[1001];

            d[start] = 0;
            pq.Enqueue((start, 0), 0);

            while (pq.Count > 0)
            {
                (int now, int dis) = pq.Dequeue();

                if (d[now] < dis) continue;

                foreach ((int next, int nextDis) in bus[now])
                {
                    if (nextDis + dis < d[next])
                    {
                        d[next] = nextDis + dis;
                        connect[next] = now;
                        pq.Enqueue((next, nextDis + dis), nextDis + dis);
                    }
                }
            }

            var city = new List<int>();
            int cur = end;

            while (cur != start)
            {
                city.Add(cur);
                cur = connect[cur]; 
            }

            city.Add(cur);
            city.Reverse();

            Console.WriteLine(d[end]);
            Console.WriteLine(city.Count);
            Console.WriteLine(string.Join(" ", city));
        }
    }
}