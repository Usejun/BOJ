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
            int n, sum, count = 0;            
            int[] array, input;            

            Input();
            Solve();

            Console.WriteLine(sum == 0 ? count - 1 : count);

            void Input()
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                n = input[0];
                sum = input[1];
                array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            void Solve()
            {   
                Sum(0, 0);
            }

            void Sum(int depth, int amount)
            {
                if (depth == n)
                {
                    if (amount == sum)                    
                        count++;                    
                    return;
                }
                Sum(depth + 1, amount + array[depth]);
                Sum(depth + 1, amount);              
            }
        }
    }
}
