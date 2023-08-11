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
            var group = new int[n][];
            var visit = new bool[n];
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
                group[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dfs(0, 0);

            Console.WriteLine(min);

            void Dfs(int start, int depth)
            {
                if (depth == n / 2)
                {
                    Calculate();                    
                    return;
                }

                for (int i = start; i < n; i++)
                    if (!visit[i])
                    {
                        visit[i] = true;
                        Dfs(i + 1, depth + 1);
                        visit[i] = false;
                    }
            }

            void Calculate()
            {
                int startTeam = 0;
                int linkTeam = 0;

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (i != j && visit[i] && visit[j])
                            startTeam += group[i][j];
                        else if (i != j && !visit[i] && !visit[j])
                            linkTeam += group[i][j];

                min = Math.Min(Math.Abs(startTeam - linkTeam), min);
            }
        }
    }
}
