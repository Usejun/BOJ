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
            int n = int.Parse(Console.ReadLine());
            var level = new int[n];
            int count = 0;

            for (int i = 0; i < n; i++)
                level[i] = int.Parse(Console.ReadLine());
                
            for (int i = n - 2; i >= 0; i--)
            {
                if (level[i] < level[i + 1])
                    continue;
                
                count += level[i] - (level[i + 1] - 1);
                level[i] = level[i + 1] - 1;
            }
            Console.WriteLine(count);
        }
    }
}
