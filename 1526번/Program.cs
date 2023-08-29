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
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 4; i--)
            {
                if (Check(i.ToString()))
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            bool Check(string str)
            {
                for (int i = 0; i < str.Length; i++)
                    if (!(str[i] == '4' || str[i] == '7'))
                        return false;
                return true;             
            }
        }
    }
}
