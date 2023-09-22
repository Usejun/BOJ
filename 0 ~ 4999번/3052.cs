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
            HashSet<int> set = new HashSet<int>();            
            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());
                set.Add(n%42);                
            }
            Console.WriteLine(set.Count);

        }
    }
}
