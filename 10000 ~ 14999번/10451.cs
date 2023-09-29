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
            int t = int.Parse(Console.ReadLine());
            int[] array;
            bool[] visit;
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine()), count = 0;
                array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                visit = new bool[n];

                for (int j = 0; j < n; j++)
                {
                    if (!visit[j])
                    {
                        visit[j] = true;
                        count++;
                        Dfs(array[j]);
                    }
                }

                sb.Append(count + "\n");
            }

            Console.Write(sb);

            void Dfs(int k)
            {
                if (!visit[k - 1])
                {
                    visit[k - 1] = true;
                    Dfs(array[k - 1]);                
                }
            }
        }
    }
}
    
