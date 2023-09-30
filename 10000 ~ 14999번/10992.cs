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
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n) Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
                else Console.WriteLine(new string(' ', n - i) + "*" + new string(' ', 2 * (i) - 3) + "*");
            }
        }
    }
}
