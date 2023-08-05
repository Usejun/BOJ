using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long l = 0;
            for (long i = 0; i < n; i++)
                l += i * n + i;
            Console.WriteLine(l);
        }
    }
}
    
