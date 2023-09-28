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
            int max = int.MinValue, index = 0;
            for (int i = 1; i < 6; i++)
            {
                int score = Console.ReadLine().Split().Select(int.Parse).Sum();
                if (max < score)
                {
                    max = score;
                    index = i;
                }               
            }
            Console.WriteLine(index + " " + max);
        } 
    }
}
    
