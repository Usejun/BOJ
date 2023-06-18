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
            int count = 0;
            while (true)
            {
                long[] d = Console.ReadLine().Split().Select(long.Parse).ToArray();
                if (d.Sum() == 0)                
                    break;
                long o = 0;
                if (d[2] % d[1] < d[0])
                    o = d[2] / d[1] * d[0] + d[2] % d[1];
                else
                    o = d[2] / d[1] * d[0] + d[0];

                Console.WriteLine($"Case {++count}: {o}");
            }

        }
    }
}
