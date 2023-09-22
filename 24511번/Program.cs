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
            var qi = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var v = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            var c = Console.ReadLine().Split().Select(int.Parse).ToArray();
          
            for (int i = qi.Length - 1; i >= 0; i--)
                if (qi[i] == 0 && m-- > 0)
                    sb.Append(v[i] + " ");
            for (int i = 0; i < m; i++)
                sb.Append(c[i] + " ");
          
            Console.Write(sb);

        }
    }
}
