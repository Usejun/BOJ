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
            var dic = new Dictionary<int, (int bn, char bc)>();
            var visit = new HashSet<int>();
            var tVisit = new HashSet<int>();
            int a, b;

            for (int i = 0; i < t; i++)
            {
                sb.Clear();
                visit.Clear();
                dic.Clear();

                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                a = input[0];
                b = input[1];

                visit.Add(a);
                dic[a] = (a, '\0');
    
                while (!dic.ContainsKey(b))
                {
                    foreach (int n in visit)
                    {
                        int d = n * 2 % 10000;
                        int s = (n + 9999) % 10000;
                        int l = ((n % 1000) * 10 + n / 1000) % 10000;
                        int r = (n % 10) * 1000 + n / 10;
                            
                        if (!dic.ContainsKey(d))
                        {
                            dic[d] = (n, 'D');
                            tVisit.Add(d);
                        }
                        if (!dic.ContainsKey(s))
                        {
                            dic[s] = (n, 'S');
                            tVisit.Add(s);
                        }
                        if (!dic.ContainsKey(l))
                        {
                            dic[l] = (n, 'L');
                            tVisit.Add(l);
                        }
                        if (!dic.ContainsKey(r))
                        {
                            dic[r] = (n, 'R');
                            tVisit.Add(r);
                        }
                    }

                    foreach (var item in tVisit)
                        visit.Add(item);                    
                    tVisit.Clear();
                }

                for (int j = b; j != a; j = dic[j].bn)
                    sb.Insert(0, dic[j].bc);
                Console.WriteLine(sb);
            }
        }
    }
}
