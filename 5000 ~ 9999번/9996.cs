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
            int n = int.Parse(Console.ReadLine());
            var pattern = Console.ReadLine().Split('*');
            while (n-- > 0)
            {
                var text = Console.ReadLine();
                var flag = text.Length >= pattern[0].Length + pattern[1].Length;
                for (int i = 0; flag && i < pattern[0].Length; i++)
                    if (text[i] != pattern[0][i])
                        flag = false;
                for (int i = 0; flag && i < pattern[1].Length; i++)
                    if (text[text.Length - 1 - i] != pattern[1][pattern[1].Length - 1 - i])
                        flag = false;
                Console.WriteLine(flag ? "DA" : "NE");
            }         
        }
    }
}