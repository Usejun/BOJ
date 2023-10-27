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
            int n = int.Parse(Console.ReadLine());
            var array = new double[n];
            double max = -1D;

            for (int i = 0; i < n; i++)            
                array[i] = double.Parse(Console.ReadLine());      

            for (int i = 0; i < n; i++)
            {
                double pow = 1;
                for (int j = i; j < n; j++)
                {
                    pow *= array[j];    
                    if (pow > max) max = pow;
                }
            }

            Console.WriteLine($"{max:f3}");
        }
    }
}