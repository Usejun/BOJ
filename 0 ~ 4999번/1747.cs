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
        static void Main(string[] s)
        {
            int max = 2000001;
            var price = Enumerable.Repeat(true, max).ToArray();
            price[1] = false;

            for (int i = 2; i < 1000; i++)            
                for (int j = 2; i * j < max; j++)                
                    price[i * j] = false;

            for (int i = 0; i < max; i++)
            {
                if (!price[i]) continue;
                var str = i.ToString();
                price[i] = str == string.Join("", str.Reverse());
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = n; i < max; i++)
            {
                if (price[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}