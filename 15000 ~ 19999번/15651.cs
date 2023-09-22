using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sb = new StringBuilder();
            int N = input[0], M = input[1];
            var array = new int[M];
            var visited = new bool[N];

            dfs(0, 0);

            Console.WriteLine(sb);

            void dfs(int start, int depth)
            {
                if (depth == M)
                {
                    sb.AppendLine(string.Join(" ", array));
                    return;
                }

                for (int i = 0; i < N; i++)
                {
                    array[depth] = i + 1;
                    dfs(i, depth + 1);
                }
            }
            
        }
    }
}
    
