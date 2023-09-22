using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main()
        {
            var sb = new StringBuilder();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = input[0], count = input[1];
            var buffer = new char[length];
            var chars = Console.ReadLine().Split().Select(char.Parse).OrderBy(x => x).ToArray();
            var vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };

            Func(0, 0, 0, 0);

            Console.Write(sb);

            void Func(int start, int depth, int vowelCount, int consonnantCount)
            {
                if (depth == length && vowelCount >= 1 && consonnantCount >= 2)
                {
                    sb.AppendLine(string.Join("", buffer));
                    return;
                }
                else if (depth == length)
                {
                    return;
                }

                for (int i = start; i < count; i++)
                {
                    buffer[depth] = chars[i];
                    if (vowel.Contains(chars[i]))
                        Func(i + 1, depth + 1, vowelCount + 1, consonnantCount);
                    else
                        Func(i + 1, depth + 1, vowelCount, consonnantCount + 1);
                }
            }

        }
    }
}
