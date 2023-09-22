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
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var answer = new int[n];
            int count = 0;
            for (int i = 0; i < 1001; i++)
                for (int j = 0; j < array.Length; j++)
                    if (array[j] == i)
                        answer[j] = count++;
            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
