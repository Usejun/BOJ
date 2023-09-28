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
            var s = Console.ReadLine().Split();
            Console.WriteLine(long.Parse(s[0] + s[1]) + long.Parse(s[2] + s[3]));
        } 
    }
}
    
