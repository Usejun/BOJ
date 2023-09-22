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
            int pow = 1, div = 9, res = 0;

            while (true)
            {
                if (n - div < 0)
                {
                    res += n * pow;
                    break;
                }
                else
                {
                    res += div * pow;
                    n -= div;
                    div *= 10;
                    pow++;
                }
            }

            Console.WriteLine(res);
        }
    }
}
    
