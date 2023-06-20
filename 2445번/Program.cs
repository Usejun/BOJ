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
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= (2 * n - 1) / 2; i++)
            {
                for (int j = 0; j < i; j++)                
                    Console.Write("*");
                for (int j = 0; j < 2 * n - i * 2; j++)                
                    Console.Write(" ");
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (int i = 0; i <= (2 * n - 1) / 2; i++)
            {
                for (int j = 0; j < n - i; j++)
                    Console.Write("*");
                for (int j = 0; j < i * 2; j++)
                    Console.Write(" ");
                for (int j = 0; j < n - i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
