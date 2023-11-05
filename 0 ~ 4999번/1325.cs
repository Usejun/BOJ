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
        static void Main(string[] s)
        {
            var sb = new System.Text.StringBuilder();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            int n = input[0], m = input[1];
            var visit = new bool[n + 1];
            var count = new int[n + 1];
            var connect = new List<int>[n + 1];

            for (int i = 1; i <= n; i++)
                connect[i] = new List<int>();                       

            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                connect[input[0]].Add(input[1]);
            }

            for (int i = 1; i <= n; i++)
            {
                visit = new bool[n + 1];
                visit[i] = true;
                count[i]++;
                Dfs(i);
            }

            int max = count.Max();
            for (int i = 1; i <= n; i++)            
                if (count[i] == max)
                   sb.Append($"{i} ");

            Console.Write(sb);

            void Dfs(int k)
            {
                foreach (var i in connect[k])       
                    if (!visit[i])
                    {
                        visit[i] = true; 
                        count[i]++;
                        Dfs(i);                                
                    }
            }
        }
    }
}