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
            var reader = new StreamReader(Console.OpenStandardInput());
            var sb = new System.Text.StringBuilder();
            Func<string> r = () => reader.ReadLine();
            Func<string[]> rs = () => r().Split();
            Func<int[]> irs = () => rs().Select(int.Parse).ToArray();
            Func<long[]> lrs = () => rs().Select(long.Parse).ToArray();
            Action<string> ap = (str) => sb.Append(str);
            Action<string> apl = (str) => sb.AppendLine(str);

            var input = irs();
            var n = input[0];
            var m = input[1];
            var array = irs().OrderBy(i => i).ToArray();
            var visit = new bool[10001];
            var buf = new int[m];

            Func(0, 0);

            void Func(int idx, int d)
            {
                if (d == m)
                {
                    apl(string.Join(" ", buf));
                    return;
                }

                for (int i = idx; i < n; i++)
                {
                    if (buf[d] == array[i]) continue;

                    buf[d] = array[i];
                    Func(i + 1, d + 1);
                }

                buf[d] = 0;
            }

            reader.Close();
            Console.Write(sb);
        }
    }
}