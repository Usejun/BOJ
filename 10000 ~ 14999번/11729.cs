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
            sb.Append((1<<n) - 1).Append('\n');
            hanoi(n, 1, 2, 3);
            Console.Write(sb);
            
            void hanoi(int N, int start, int sub, int end)
            {
                if (N == 1)
                {
                    sb.AppendLine($"{start} {end}");
                }
                else
                {
                    hanoi(N - 1, start, end, sub);
                    sb.AppendLine($"{start} {end}");
                    hanoi(N - 1, sub, start, end);
                }
            }
        }
    }
}
