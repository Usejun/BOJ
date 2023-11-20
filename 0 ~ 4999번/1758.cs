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
            var l = new List<int>();
            long sum = 0;

            for (int i = 0; i < n; i++)
                l.Add(int.Parse(Console.ReadLine()));            

            l = l.OrderByDescending(i=>i).ToList();

            for (int i = 0; i < n; i++)
                sum += l[i] - i < 0 ? 0 : l[i] - i;

            Console.WriteLine(sum);
        }
    }
}