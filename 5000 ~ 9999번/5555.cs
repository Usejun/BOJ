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
            var str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                var ring = Console.ReadLine();
                ring = ring + ring;
                if (ring.Contains(str))
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}