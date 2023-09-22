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
            for(int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(double.Parse).ToList();
                var score = input.Skip(1).ToList();             
                Console.WriteLine($"{score.Where(x => x > score.Average()).Count()*100/input[0]:0.000}%");
            }
        }
    }
}
