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
            var input = Console.ReadLine();
            var str = new HashSet<string>();
            for (int i = 0; i < input.Length; i++)      
                for (int j = input.Length - i; j > 0; j--)
                        str.Add(input.Substring(i, j));                
            Console.WriteLine(str.Count);
        }       
    }
}
    
