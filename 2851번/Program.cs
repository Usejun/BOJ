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
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                var input = int.Parse(Console.ReadLine());
                if (Math.Abs(sum + input - 100) > Math.Abs(sum - 100))
                    break;
                
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}
    
