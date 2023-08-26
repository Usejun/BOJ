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
            int count, price;
            int[] coin, dp, input;

            Input();
            Solve();

            Console.WriteLine(dp[price]);

            void Input()
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                (count, price) = (input[0], input[1]);

                coin = new int[count];
                dp = new int[price + 1];
                dp[0] = 1;

                for (int i = 0; i < count; i++)               
                    coin[i] = int.Parse(Console.ReadLine());
                
            }

            void Solve()
            {
                for (int i = 0; i < count; i++)
                {
                    for (int j = coin[i]; j <= price; j++)
                    {
                        dp[j] += dp[j - coin[i]];
                    }
                    Console.WriteLine(string.Join(" ", dp));
                }
            }
        }
    }
}
