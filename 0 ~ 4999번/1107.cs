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
            string channel;
            int n, answer = int.MaxValue;
            int[] input = new int[0];
            bool[] button;            

            Input();
            Find(0, "");

            answer = Math.Min(Math.Abs(int.Parse(channel) - 100), answer);

            Console.WriteLine(answer);

            void Input()
            {
                channel = Console.ReadLine();
                n = int.Parse(Console.ReadLine());
                if (n != 0)
                    input = Console.ReadLine().Split().Select(int.Parse).ToArray();                
                button = new bool[10];

                foreach (int i in input)
                    button[i] = true;               
            }

            void Find(int depth, string pressed)
            {
                if (depth == channel.Length + 1)                 
                    return;                                  
                

                for (int i = 0; i < 10; i++)
                    if (!button[i])
                    {
                        int count = Math.Abs(int.Parse(channel) - int.Parse(pressed + i));
                        count = int.Parse(pressed + i) == 0 ? count + 1 : count + depth + 1;
                        answer = Math.Min(answer, count);
                        Find(depth + 1, pressed + i);                      
                    }
            }
           
        }
    }
}
