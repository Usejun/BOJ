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
            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }
            var trim = Math.Round(n * 0.15, MidpointRounding.AwayFromZero);
            var idea = new int[n];

            for (int i = 0; i < n; i++)
                idea[i] = int.Parse(Console.ReadLine());

            Array.Sort(idea);

            int sum = 0;

            for (var i = trim; i < n - trim; i++)
                sum += idea[(int)i];

            Console.WriteLine(Math.Round(sum / (n - 2.0 * trim), MidpointRounding.AwayFromZero));
        }
    }
}
