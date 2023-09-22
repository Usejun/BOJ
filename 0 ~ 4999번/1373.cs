using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder(); 

            while (input.Length % 3 != 0) 
                input = "0" + input; 

            for (int i = 0; i < input.Length; i += 3)            
                sb.Append((input[i] - '0') * 4 + (input[i+1] - '0') * 2 + (input[i+2] - '0') * 1);

            Console.WriteLine(sb);
        }
    }
