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
            var array = new long[91];
            array[0] = 0; 
            array[1] = 1;

            for (int i = 2; i < n + 1; i++)
                array[i] = array[i - 1] + array[i - 2];

            Console.WriteLine(array[n]);
        }
    }
}
    
