using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;

namespace CodingTest
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            var baseStr = Console.ReadLine();
            var containStr = Console.ReadLine();
            int count = 0, index = 0;
            while (true)
            {
                if (index + containStr.Length > baseStr.Length)                
                    break;
                
                if (baseStr.Substring(index, containStr.Length) == containStr)
                {
                    index += containStr.Length;
                    count++;
                }
                else
                    index++;
            }
            Console.WriteLine(count);
        }
    }
}
    
