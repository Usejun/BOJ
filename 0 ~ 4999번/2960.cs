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
            var d = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var l = new List<int>();
            int count = d[1];
            int n = 0;

            for (int i = 2; i <= d[0]; i++)
            {
                l.Add(i);
            }
            
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] == 0)
                    continue;
                n = l[i];
                for (int j = i; j < l.Count; j += n)
                {
                    if (l[j] != 0)
                    {
                        count--;
                        if (count == 0)
                        {
                            Console.WriteLine(l[j]);
                            return;
                        }
                        l[j] = 0;

                    }
                }
            }
        }
    }
}
