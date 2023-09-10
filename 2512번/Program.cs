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
            var price = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = int.Parse(Console.ReadLine());
            int low = 0, high = price.Max(), mid = 0;
            int answer = 0;

            while (low <= high)
            {
                int sum = 0;

                mid = (high + low) / 2;

                for (int i = 0; i < n; i++)
                    if (price[i] > mid)
                        sum += mid;
                    else
                        sum += price[i];

                if (sum > max)
                    high = mid - 1;
                else
                {
                    low = mid + 1;
                    answer = mid;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
