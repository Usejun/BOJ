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
            var sb = new System.Text.StringBuilder();
            int n = int.Parse(Console.ReadLine());
            var dequeue = new LinkedList<int>();

            for (int i = 0; i < n; i++)
            {
                var com = Console.ReadLine().Split().Select(int.Parse).ToList();
                if (com.Count == 2)
                    _ = com[0] == 1 ? dequeue.AddFirst(com[1]) : dequeue.AddLast(com[1]);
                if (com[0] == 3)
                {
                    sb.Append(dequeue.Any() ? dequeue.First.Value : -1).Append("\n");
                    if (dequeue.Any()) dequeue.RemoveFirst();
                }
                if (com[0] == 4)
                {
                    sb.Append(dequeue.Any() ? dequeue.Last.Value : -1).Append("\n");
                    if (dequeue.Any()) dequeue.RemoveLast();
                }
                if (com[0] == 5)
                    sb.Append(dequeue.Count).Append("\n");
                if (com[0] == 6)
                    sb.Append(dequeue.Any() ? 0 : 1).Append("\n");
                if (com[0] == 7)
                    sb.Append(dequeue.Any() ? dequeue.First.Value : -1).Append("\n");
                if (com[0] == 8)
                    sb.Append(dequeue.Any() ? dequeue.Last.Value : -1).Append("\n");
            }

            Console.Write(sb);
        }
    }
}
