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
            int n = int.Parse(Console.ReadLine());
            var l = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();
            int max = 0;
            
            for (int i = 0; i < n; i++)
                max = max < l[i] + i + 2 ? l[i] + i + 2 : max;
                
            Console.WriteLine(max);
        }
    }
}
