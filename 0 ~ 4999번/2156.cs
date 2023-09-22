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
            var wein = new int[10002];
            var drink = new int[10001];

            for (int i = 1; i <= n; i++)            
                wein[i] = int.Parse(Console.ReadLine());

            drink[1] = wein[1];
            drink[2] = wein[1] + wein[2];

            for (int i = 3; i <= n; i++)
            {
                drink[i] = Math.Max(drink[i - 2] + wein[i], drink[i - 3] + wein[i - 1] + wein[i]);
                drink[i] = Math.Max(drink[i], drink[i - 1]);
            }

            Console.WriteLine(drink[n]);
        }       
    }
}
    
