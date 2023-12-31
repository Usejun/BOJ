using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            int LEN = 4000001;            
            var prime = Enumerable.Repeat(true, LEN).ToArray();   
            var sum = new List<long>() { 0 };

            for (int i = 2; i < 2001; i++)
            {
                if (!prime[i]) continue;

                for (int j = 1; i * j < LEN; j++)
                    prime[i * j] = false; 
                prime[i] = true;
            }

            for (int i = 2; i < LEN; i++)            
                if (prime[i])
                    sum.Add(sum[sum.Count - 1] + i);

            long n = long.Parse(Console.ReadLine());
            int count = 0, l = 0, r = 1;

            while (r < sum.Count)
            {
                long now = sum[r] - sum[l];
                if (now > n) l++;
                else if (now < n) r++;
                else
                {
                    count++;
                    l++;
                }
            }

            Console.WriteLine(n < 2 ? 0 : count);

        }

    }
}