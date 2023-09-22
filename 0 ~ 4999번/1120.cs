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
            var input = Console.ReadLine().Split();
            string A = input[0], B = input[1];
            int subLen = B.Length - A.Length, min = int.MaxValue;

            for (int i = 0; i < subLen + 1; i++)
            {
                int c = 0;
                for (int j = i; j < i + A.Length; j++)
                    if (A[j - i] != B[j])
                        c++;
                if (c < min)
                    min = c;
            }

            Console.Write(min);              
        }
    }
}
    
