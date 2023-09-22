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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var set = new int[n + 2];
            var sb = new StringBuilder();

            for (int i = 0; i < n + 2; i++)
                set[i] = i;

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (input[0] == 0)
                    set[Find(input[2])] = Find(input[1]); 
                else
                    sb.AppendLine(Find(input[1]) == Find(input[2]) ? "YES" : "NO");
            }

            Console.Write(sb);

            int Find(int c1)
            {
                if (c1 == set[c1]) return c1;
                else
                {
                    set[c1] = Find(set[c1]);
                    return set[c1];
                }
            }
            
        }
    }
}
