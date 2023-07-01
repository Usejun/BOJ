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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], kim = input[1], lim = input[2], result = 0;

            while (kim != lim)
            {
                (kim, lim) = ((kim + 1) / 2, (lim + 1) / 2);
                result++;
            }

            Console.WriteLine(result);

        }
    }
}
    
