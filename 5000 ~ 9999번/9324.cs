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
            for (int i = 0; i < t; i++)
            {
                var alp = new int[26];
                var str = Console.ReadLine();
                var isFake = false;

                for (int j = 0; !isFake && j < str.Length; j++)
                {
                    int k = str[j] - 'A';
                    alp[k]++;
                    if (alp[k] % 3 == 0)
                    {
                        if (j + 1 >= str.Length || str[j + 1] != str[j])
                            isFake = true;
                        else j++;
                    }                  
                }
                Console.WriteLine(isFake ? "FAKE" : "OK");
            }
        }
    }
}