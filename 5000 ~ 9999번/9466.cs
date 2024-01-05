using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            var sb = new System.Text.StringBuilder();

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var v = new bool[n + 1];
                var l = new List<int>();
                var c = n;

                for (int j = 1; j <= n; j++)
                {
                    if (!v[j])
                    {
                        l.Clear();
                        DFS(j);
                    }
                }

                sb.Append(c).Append('\n');

                void DFS(int k)
                {
                    v[k] = true;
                    l.Add(k);

                    if (v[a[k - 1]])
                    {
                        if (l.Contains(a[k - 1]))
                        {
                            for (int i = l.IndexOf(a[k - 1]); i < l.Count; i++)
                                c--;
                        }
                        return;
                    }
                    else
                        DFS(a[k - 1]);
                }     
            }

            Console.Write(sb);
        }
    }
}