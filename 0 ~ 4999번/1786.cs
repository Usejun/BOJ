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
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();
            int pLength = pattern.Length, tLength = text.Length, count = 0, j = 0;
            var answer = new List<int>();
            var pi = new int[pLength];

            for (int i = 1; i < pLength; i++)
            {
                while (j > 0 && pattern[i] != pattern[j])
                    j = pi[j - 1];
                if (pattern[i] == pattern[j]) 
                    pi[i] = ++j;
            }

            j = 0;

            for (int i = 0; i < tLength; i++)
            {
                while (j > 0 && text[i] != pattern[j])
                    j = pi[j - 1];
                if (text[i] == pattern[j])
                    if (j == pLength - 1)
                    {
                        j = pi[j];
                        answer.Add(i + 1 - pLength + 1);
                        count++;
                    }
                    else
                        j++;             
            }

            Console.WriteLine(count);
            Console.WriteLine(string.Join(" ", answer));


        }
    }
}
    
