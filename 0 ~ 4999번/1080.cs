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
            int n = input[0], m = input[1];
            var map = new char[n][];
            var answer = new string[n];
            int count = 0;
            bool flag = false;

            for (int i = 0; i < n; i++)            
                map[i] = Console.ReadLine().ToCharArray();
            for (int i = 0; i < n; i++)
                answer[i] = Console.ReadLine();

            if (n < 3 || m < 3)
            {
                flag = false;
                for (int i = 0; i < n; i++)               
                    for (int j = 0; j < m; j++)
                        if (map[i][j] != answer[i][j])                      
                            flag = true;

                Console.WriteLine(flag ? -1 : 0);
                return;
            }

            for (int i = 0; i < n - 2; i++)
                for (int j = 0; j < m - 2; j++)
                    if (map[i][j] != answer[i][j])
                    {
                        for (int k = 0; k < 3; k++)
                            for (int q = 0; q < 3; q++)
                                map[i + k][j + q] = map[i + k][j + q] == '0' ? '1' : '0';
                        count++;
                    }

            flag = false;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (map[i][j] != answer[i][j])
                        flag = true;

            Console.WriteLine(flag ? -1 : count);
        }
    }
}
