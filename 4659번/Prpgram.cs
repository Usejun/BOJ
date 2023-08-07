using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            char[] vow = { 'a', 'e', 'i', 'o', 'u' };

            bool check1(string str)
            {              
                for (int i = 0; i < str.Length; i++)                
                    if (vow.Contains(str[i]))
                        return true;
                return false;
            }

            bool check2(string str)
            {
                int vowCount = 0;
                int conCount = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (vow.Contains(str[i]))
                    {
                        vowCount++;
                        conCount = 0;
                    }
                    else
                    {
                        conCount++;
                        vowCount = 0;
                    }

                    if (vowCount == 3 || conCount == 3)
                        return false;                    
                }
                return true;
            }

            bool check3(string str)
            {
                for (int i = 1; i < str.Length; i++)                
                    if (str[i - 1] == str[i] && (str[i] != 'e' && str[i] != 'o'))                    
                        return false;
                return true;
            }

            var text = "";

            while (true)
            {
                text = Console.ReadLine();
                if (text == "end")
                    break;
                if (check1(text) && check2(text) && check3(text))
                    Console.WriteLine($"<{text}> is acceptable.");
                else
                    Console.WriteLine($"<{text}> is not acceptable.");
            }          
        }
    }
}
