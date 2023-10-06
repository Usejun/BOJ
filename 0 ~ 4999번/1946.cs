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
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var list = new int[n][];

                for (int j = 0; j < n; j++)
                    list[j] = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int answer = 0;
                list = list.OrderBy(k => k[0]).ToArray();
                int min = list[0][1];

                foreach (var item in list)
                    if (item[1] <= min)
                    {
                        answer++;
                        min = item[1];
                    }
                    
                Console.WriteLine(answer);
            }
        }
    }
}