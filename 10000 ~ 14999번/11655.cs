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
            string input = Console.ReadLine();
            string s = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    s += (char)((input[i] - 'A' + 13) % 26 + 'A') ;
                }
                else if (input[i] >= 'a' && input[i] <= 'z')
                {
                    s += (char)((input[i] - 'a' + 13) % 26 + 'a');
                }
                else
                {
                    s += input[i];
                }
            }
            Console.WriteLine(s);
        }
    }
}
