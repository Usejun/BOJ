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
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = 0, count = 0, answer;
            
            foreach(int i in a)
            {
                if (i > max)
                {
                    max = i;
                    count = 0;
                }
                else count++;
                answer = Math.Max(answer, count);
                    
            }
            Console.WriteLine(answer);
        }
    }
}
