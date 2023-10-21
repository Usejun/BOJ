using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.Write(Enumerable.Range(1, input[0]).Where(i => i.ToString().Contains($"{(char)('0' + input[1])}")).Select(i => i.ToString()).Sum(i => i.Count(j => j == '0' + input[1])));          
        }
    }
}