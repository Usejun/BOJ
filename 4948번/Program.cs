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
            var primeNumber = new int[123456 * 2 + 1];

            for (int i = 1; i <= 123456 * 2; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i && isPrime; j++)
                    if (i != j && i % j == 0)
                        isPrime = false;
                if (isPrime)
                    primeNumber[i]++;               
            }

            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                int count = 0;
                for (int i = n + 1; i <= 2 * n; i++)                
                    count += primeNumber[i];
                Console.WriteLine(count);
            }
        }
    }
}
    
