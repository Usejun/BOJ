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
            var cards = new int[n][];
            int max = 0;
            int index = -1;

            for (int i = 0; i < n; i++)
                cards[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = j + 1; k < 4; k++)
                        for (int q = k + 1; q < 5; q++)
                        {
                            int sum = (cards[i][j] + cards[i][k] + cards[i][q]) % 10;
                            if (sum >= max)
                            {
                                max = sum;
                                index = i;
                            }
                        }
                    
            Console.WriteLine(index + 1);
        }
    }
}