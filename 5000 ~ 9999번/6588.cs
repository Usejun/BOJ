using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            var sb = new System.Text.StringBuilder();
            var prime = Enumerable.Repeat(true, 1000000).ToArray();

            for (int i = 2; i < 1000; i++)
            {
                if (!prime[i]) continue;
                for (int j = 1; 1000000 > i * j; j++)
                    prime[i * j] = false;
                prime[i] = true;
            }

            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0) break; ;
                for (int j = 2; j < n; j++)
                    if (prime[j] && prime[n - j])
                    {
                        sb.Append($"{n} = {j} + {n - j}\n");
                        break;
                    }
            }

            Console.Write(sb);
        }
    }
}
    
