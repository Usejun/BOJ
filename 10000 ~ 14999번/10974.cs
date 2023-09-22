using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var buffer = new int[n];

            B(0);

            void B(int depth)
            {
                if (depth == n)
                {
                    Console.WriteLine(string.Join(" ", buffer));
                    return;
                }

                for (int i = 1; i <= n; i++)
                {
                    if (buffer.Contains(i))
                        continue;

                    buffer[depth] = i;
                    B(depth + 1);
                    buffer[depth] = 0;
                }
            }
        }
    }
}
