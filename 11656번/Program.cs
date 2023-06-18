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
            string text = Console.ReadLine();
            List<string> list = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                list.Add(text.Substring(i));
            }

            list.Sort();

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }          
        }
    }
}
