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
            BigInteger n1 = 0, n2 = 1;

            for (int i = 0; i < n; i++)            
                (n1, n2) = (n2, n1 + n2);
            Console.WriteLine(n1);
        }
    }
}
