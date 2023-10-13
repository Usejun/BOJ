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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var str = new string[n];
            var alp = new int[26];

            for (int i = 0; i < n; i++)
                str[i] = Console.ReadLine();

            var dna = "";
            int ham = 0;
                    
            for (int i = 0; i < m; i++)
            {
                alp = new int[26];
                for (int j = 0; j < n; j++)
                    alp[str[j][i] - 'A']++;

                for (int k = 0; k < 26; k++)
                    if (alp[k] == alp.Max())
                    {
                        dna += (char)('A' + k);
                        break;
                    }
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (str[i][j] != dna[j])
                        ham++;

            Console.WriteLine(dna);
            Console.WriteLine(ham);
        }
    }
}