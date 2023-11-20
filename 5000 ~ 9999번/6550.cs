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
            try
            {
                while (true)
                {
                    var t = Console.ReadLine();
                    if (t == null || t == "")
                        break;
                    var text = t.Split();
                    int eq = 0;
                    for (int i = 0; i < text[1].Length && eq < text[0].Length; i++)
                        if (text[0][eq] == text[1][i])
                            eq++;
                    Console.WriteLine(eq == text[0].Length ? "Yes" : "No");
                }
            }
            catch { }         
        }
    }
}