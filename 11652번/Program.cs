using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            int n = int.Parse(Console.ReadLine());
            var cards = new Dictionary<long, long>();
            for (int i = 0; i < n; i++)
            {
                var input = long.Parse(Console.ReadLine());
                if (!cards.ContainsKey(input))
                    cards.Add(input, 0);

                cards[input]++;                
            }

            Console.WriteLine(cards.OrderByDescending(x => x.Value).ThenBy(y => y.Key).ToArray()[0].Key);

        }
    }
}
    
