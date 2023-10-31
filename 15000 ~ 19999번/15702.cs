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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], m = input[1];
            var score = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var student = new (int, int)[m];

            for (int i = 0; i < m; i++)
            {
                var info = Console.ReadLine().Split();
                int sum = 0;
                for (int j = 1; j <= n; j++)
                    sum += info[j] == "O" ? score[j - 1] : 0;

                student[i] = (int.Parse(info[0]), sum);
            }

            var answer = student.OrderByDescending(i => i.Item2).ThenBy(i => i.Item1).First();

            Console.WriteLine($"{answer.Item1} {answer.Item2}");
        }
    }
}