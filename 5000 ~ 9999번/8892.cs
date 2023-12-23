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
            int t = int.Parse(Console.ReadLine());
            for (int z = 0; z < t; z++)
            {
                int n = int.Parse(Console.ReadLine());
                var l = new List<string>();
                for (int i = 0; i < n; i++)
                    l.Add(Console.ReadLine());

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (i != j && l[i] + l[j] == string.Join("", (l[i] + l[j]).Reverse()))
                        {
                            Console.WriteLine(l[i] + l[j]);
                            goto End;
                        }
                Console.WriteLine(0);
                End: { }                                       
            }
        }
    }
}