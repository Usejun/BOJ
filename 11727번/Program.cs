using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            int n = int.Parse(Console.ReadLine());
            var dy = new int[n + 1];
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            dy[1] = 1; dy[2] = 3;
            for (int i = 3; i <= n; i++)
                dy[i] = (dy[i - 1] + dy[i - 2] * 2) % 10007;
            Console.WriteLine(dy[n]);

        }
    }
}
