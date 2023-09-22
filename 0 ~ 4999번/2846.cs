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
            var road = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int min = road[0];
            int result = 0;

            for (int i = 1; i < n; i++)
                if (road[i - 1] < road[i])
                    result = Math.Max(result, road[i] - min);
                else
                    min = road[i];

            Console.WriteLine(result);

        }
    }
}
    
