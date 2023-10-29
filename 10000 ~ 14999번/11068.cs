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
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                bool palindrome = false;
                for (int j = 2; j < 65 && !palindrome; j++)
                    palindrome = Palindrome(n, j);

                Console.WriteLine(palindrome ? 1 : 0);
            }

            bool Palindrome(int k, int q)
            {
                string s = "";

                while (k != 0)
                {
                    s += (char)(k % q + '0');
                    k = k / q;
                }

                return s == string.Join("", s.Reverse());
            }
        }
    }
}