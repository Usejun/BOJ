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
            int close(string s1, string s2)
            {
                int dir = 0;
                for (int i = 0; i < 4; i++)
                    if (s1[i] != s2[i])
                        dir++;
                return dir;
            }

            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int min = int.MaxValue;
                var mbti = Console.ReadLine().Split();
                if (n > 32)
                {
                    Console.WriteLine(0);
                    continue;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        for (int k = j + 1; k < n; k++)
                        {
                            min = Math.Min(min, close(mbti[i], mbti[j]) +
                                                close(mbti[j], mbti[k]) +
                                                close(mbti[i], mbti[k]));
                            if (min == 0)
                                break;
                        }
                        if (min == 0)
                            break;
                    }
                    if (min == 0)
                        break;
                }
                Console.WriteLine(min);
            }
        }
    }
}
