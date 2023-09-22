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
            int n;
            int count = 0;

            Input();
            Solve();

            Console.WriteLine(n == 1 ? 1 : count);

            void Input()
            {
                n = int.Parse(Console.ReadLine());
            }

            void Solve()
            {
                for (int i = 1; i * i < n; i++)
                    count++;                
            }
        }
    }
}
