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
            int n = int.Parse(Console.ReadLine());
            var score = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 1; i < n; i++)            
                if (score[i - 1] != 0 && score[i] != 0)
                    score[i] = score[i - 1] + 1;

            Console.WriteLine(score.Sum());
        }
    }
}
