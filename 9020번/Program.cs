using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var primeNumber = Enumerable.Range(0, 10001).Select(x => true).ToArray();

            for (int i = 2; i < primeNumber.Length; i++)
            {
                if (!primeNumber[i])
                    continue;
                for (int j = 2; i * j < primeNumber.Length; j++)
                    primeNumber[i * j] = false;
                primeNumber[i] = true;
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                (int a, int b) = (-1000, 1000);
                for (int j = 2; j < number; j++)
                    if (primeNumber[j] && primeNumber[number - j])
                        if (Math.Abs(a - b) > Math.Abs(number - 2 * j))
                            (a, b) = (j, number - j);
                Console.WriteLine($"{a} {b}");
            }
            
        }
    }
}
    
