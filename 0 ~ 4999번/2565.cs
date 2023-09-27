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
            var line = new List<(int, int)>() { (0, 0) };
            var dp = new int[101];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                line.Add((input[0], input[1]));
            }

            line = line.OrderBy(x => x.Item1).ToList();

            for (int i = 1; i <= n; i++)
                for (int j = 0; j < i; j++)
                    if (line[i].Item2 > line[j].Item2)
                        if (dp[j] >= dp[i])
                            dp[i] = dp[j] + 1;

            Console.WriteLine(n - dp.Max());
        } 
    }
}
