using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            Console.WriteLine(int.Parse(num1) * Convert.ToInt32(num2[2] - '0'));
            Console.WriteLine(int.Parse(num1) * Convert.ToInt32(num2[1] - '0'));
            Console.WriteLine(int.Parse(num1) * Convert.ToInt32(num2[0] - '0'));
            Console.WriteLine(int.Parse(num1) * int.Parse(num2));
        }
    }    
}
