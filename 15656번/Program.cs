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
            var w = new StreamWriter(Console.OpenStandardOutput());
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], length = input[1];
            var array = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            var buffer = new int[length];

            Func(0);
            w.Close();

            void Func(int depth)
            {
                if (depth == length)
                {
                    w.WriteLine(string.Join(" ", buffer));
                    return;
                }

                for (int i = 0; i < n; i++)
                {
                    buffer[depth] = array[i];
                    Func(depth + 1);
                }
            }
        }
    }
}
