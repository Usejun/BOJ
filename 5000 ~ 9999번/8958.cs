using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int score = 0;
                int allScore = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'O')
                    {
                        score++;
                        allScore += score;
                    }
                    else
                    {
                        score = 0;
                    }
                }
                Console.WriteLine(allScore);
            }

        }
    }
}
