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
            var name = new Dictionary<string, int>();
            string input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                if (!name.ContainsKey(input))
                    name.Add(input, 0);

                name[input]++;
            }

            Console.WriteLine(name.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToArray()[0].Key);
        }
    }
}
    
