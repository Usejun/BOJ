using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var l = new int[n[0]+1,n[1]+1];
            for (int i = 0; i < n[0]+1; i++)
                l[i, 0] = 1;
            for (int i = 1; i < n[0] + 1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    l[i, j] = l[i - 1, j - 1] + l[i - 1, j]; 
                }
            }
            Console.WriteLine(l[n[0] - 1, n[1] - 1]);
        }
    }
}
