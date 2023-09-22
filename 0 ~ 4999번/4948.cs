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
            var primeNumber = Enumerable.Range(0, 246913).Select(n => true).ToArray();

            for (int i = 2; i < primeNumber.Length; i++)
            {
                if (!primeNumber[i])
                    continue;
                for (int j = 2; i * j < primeNumber.Length ; j++)
                    primeNumber[i * j] = false;
                primeNumber[i] = true;
            }

            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) break;
                int count = 0;
                for (int i = n + 1; i <= 2 * n; i++)
                    if (primeNumber[i])
                        count++;
                Console.WriteLine(count);
            }
        }
    }
}
    
