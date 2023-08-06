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
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();
            var lcs = new int[1000, 1000];

            for (int i = 0; i <= str1.Length; i++)
                for (int j = 0; j <= str2.Length; j++)
                    if (i == 0 || j == 0)
                        lcs[i, j] = 0;
                    else if (str1[i - 1] == str2[j - 1])
                        lcs[i, j] = lcs[i - 1, j - 1] + 1;
                    else
                        lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);

            Console.WriteLine(lcs[str1.Length, str2.Length]);

        }
    }
}
