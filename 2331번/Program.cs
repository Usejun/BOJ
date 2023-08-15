using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = input[0], pow = input[1];
            var array = new int[1001];
            int index = 0, i = 0;
            bool isFind = false;

            array[index++] = start;

            while (!isFind)
            {
                int back = array[index - 1];
                int value = 0;
                while (back != 0)
                {
                    value += (int)Math.Pow(back % 10, pow);
                    back /= 10;
                }

                for (i = 0; i < 1001; i++)
                    if (array[i] == value)
                    {
                        isFind = true;
                        break;
                    }

                array[index++] = value;
            }

            Console.WriteLine(i);
        }
    }
}
