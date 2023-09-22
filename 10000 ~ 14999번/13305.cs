using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dis = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var price = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 1; i < n; i++)
                 if (price[i - 1] < price[i])
                    price[i] = price[i - 1];                

            for (int i = 0; i < dis.Length; i++)
                sum += dis[i] * price[i];

            Console.WriteLine(sum);
        }
    }
}
