using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var answer = "D";
                var aCount = new int[5];
                var bCount = new int[5];
                var a = Console.ReadLine().Split().Select(int.Parse).Skip(1).ToArray();
                var b = Console.ReadLine().Split().Select(int.Parse).Skip(1).ToArray();

                for (int j = 0; j < a.Length; j++)
                    aCount[a[j]]++;
                for (int j = 0; j < b.Length; j++)
                    bCount[b[j]]++;

                for (int j = 4; j > 0; j--)
                {
                    if (aCount[j] > bCount[j])
                    {
                        answer = "A";
                        break;
                    }
                    else if (aCount[j] < bCount[j])
                    {
                        answer = "B";
                        break;
                    }
                }

                Console.WriteLine(answer);
            }
        }
    }
}
