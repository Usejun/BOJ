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
            var ballon = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var deq = new LinkedList<(int, int)>();
            var answer = new List<int>();

            for (int i = 0; i < n; i++)            
                deq.AddLast((ballon[i], i + 1));
            
            while (deq.Any())
            {
                (int k, int i) = deq.First.Value;
                answer.Add(i);
                deq.RemoveFirst();
                if (k < 0)
                    for (int j = 0; j < -k; j++)
                    {
                        if (deq.Any())
                        {
                            var node = deq.Last;
                            deq.RemoveLast();
                            deq.AddFirst(node);
                        }
                    }
                else
                    for (int j = 0; j < k - 1; j++)
                    {
                        if (deq.Any())
                        {
                            var node = deq.First;
                            deq.RemoveFirst();
                            deq.AddLast(node);
                        }
                    }
            }
            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
