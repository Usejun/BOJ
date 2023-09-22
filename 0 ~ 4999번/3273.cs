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
            int sum = int.Parse(Console.ReadLine());
            var sort = new bool[1000001];
            int count = 0;

            foreach (int i in array) sort[i] = true;

            foreach (int i in array)
            {
                if (sum - i >= 0 && sum - i != i && sort[sum - i] && sort[i])
                {
                    count++;
                    sort[sum - i] = false;
                }
            }

            Console.WriteLine(count);

        }
    }
}
