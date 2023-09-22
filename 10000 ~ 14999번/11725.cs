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
            int n;
            int[] input, parents;
            bool[] visit;
            Dictionary<int, List<int>> connection;

            Input();
            Dfs(1);

            Console.WriteLine(string.Join("\n", parents.Skip(2)));

            void Input()
            {
                n = int.Parse(Console.ReadLine());
                parents = new int[n + 1];
                connection = new Dictionary<int, List<int>>();
                visit = new bool[n + 1];

                for (int i = 1; i <= n; i++)
                    connection.Add(i, new List<int>());

                for (int i = 0; i < n - 1; i++)
                {
                    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    connection[input[0]].Add(input[1]);
                    connection[input[1]].Add(input[0]);
                }
            }
            
            void Dfs(int start)
            {
                for (int i = 0; i < connection[start].Count; i++)
                    if (!visit[connection[start][i]])
                    {
                        visit[connection[start][i]] = true;
                        parents[connection[start][i]] = start;
                        Dfs(connection[start][i]);
                    }
            }
        }
    }
}
