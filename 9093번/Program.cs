using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                Console.WriteLine(string.Join(" ", Console.ReadLine().Split().Select(x => string.Join("", x.Reverse()))));
        }
    }
}
