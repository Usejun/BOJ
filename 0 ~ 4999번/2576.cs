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
            int min = 101, sum = 0;
            for (int i = 0; i < 7; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0) continue;
                sum += n;
                min = min > n ? n : min;                
            }
            Console.WriteLine($"{(sum == 0 ? "-1" : $"{sum}\n{min}" )}");
        }
    }
}
    
