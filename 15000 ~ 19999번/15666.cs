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
            var sb = new StringBuilder();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var arr = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            var buf = new int[m];

            Find(0, 0);

            Console.WriteLine(sb);

            void Find(int start, int depth)
            {
                if (depth == m)
                {
                    sb.AppendLine(string.Join(" ", buf));
                    return;
                }

                int set = 0;

                for (int i = start; i < n; i++)
                {
                    if (arr[i] != set)
                    {
                        buf[depth] = arr[i];
                        set = arr[i];
                        Find(i, depth + 1);
                    }
                }
            }
        }
    }
}
