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
            var text = Console.ReadLine();
            var result = new string('z', text.Length);

            for (int i = 0; i < text.Length - 2; i++)
                for (int j = i + 1; j < text.Length - 1; j++)
                {
                    string newString = "";

                    for (int k = i; k >= 0; k--)
                        newString += text[k];
                    for (int k = j; k > i; k--)
                        newString += text[k];
                    for (int k = text.Length - 1; k > j; k--)
                        newString += text[k];

                    if (string.Compare(result, newString) > 0)
                        result = newString;
                }
            Console.WriteLine(result);

        }
    }
}
    
