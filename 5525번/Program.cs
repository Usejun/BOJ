using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            var text = Console.ReadLine();
            var pattern = new StringBuilder().Insert(0, "IO", n).Append("I");            
            var tab = new int[pattern.Length];
            int j = 0, count = 0;

            for (int i = 1; i < pattern.Length; i++)
            {
                while (j > 0 && pattern[i] != pattern[j]) j = tab[j - 1];
                if (pattern[i] == pattern[j]) tab[i] = ++j;
            }

            j = 0;
            for (int i = 0; i < m; i++)
            {
                while (j > 0 && text[i] != pattern[j]) j = tab[j - 1];
                if (text[i] == pattern[j])
                    if (j == pattern.Length - 1)
                    {
                        count++;
                        j = tab[j];
                    }
                    else
                        j++;
            }

            Console.WriteLine(count);
        }
    }
}
    
