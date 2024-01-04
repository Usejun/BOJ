using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    internal class Program
    {             
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], l = input[1];
            var map = new int[n][];
            int count = 0;

            for (int i = 0; i < n; i++)
                map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                if (Row(i)) count++;
                if (Column(i)) count++; 
            }

            Console.WriteLine(count);

            bool Row(int k)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (map[k][i] - map[k][i + 1] == -1) // 오르막
                    {
                        for (int j = 0; j < l; j++)
                            if (i - j < 0 || map[k][i - j] != map[k][i])
                                return false;
                        for (int j = l; j < l * 2; j++)
                            if (i - j >= 0 && map[k][i - j] >= map[k][i + 1])
                                return false;
                    }
                    else if (map[k][i] - map[k][i + 1] == 1) // 내리막
                    {
                        for (int j = 1; j <= l; j++)
                            if (i + j >= n || map[k][i + j] != map[k][i] - 1)
                                return false;
                        for (int j = l; j <= l * 2; j++)
                            if (i + j < n && map[k][i + j] >= map[k][i])
                                return false;
                    }
                    else if (Math.Abs(map[k][i] - map[k][i + 1]) > 1) return false;
                }

                return true;
            }

            bool Column(int k) 
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (map[i][k] - map[i + 1][k] == -1) // 오르막
                    {
                        for (int j = 0; j < l; j++)
                            if (i - j < 0 || map[i - j][k] != map[i][k])
                                return false;
                        for (int j = l; j < l * 2; j++)
                            if (i - j >= 0 && map[i - j][k] >= map[i + 1][k])
                                return false;
                    }
                    else if (map[i][k] - map[i + 1][k] == 1) // 내리막
                    {
                        for (int j = 1; j <= l; j++)
                            if (i + j >= n || map[i + j][k] != map[i][k] - 1)
                                return false;
                        for (int j = l; j <= l * 2; j++)
                            if (i + j < n && map[i + j][k] >= map[i][k])
                                return false;
                    }
                    else if (Math.Abs(map[i][k] - map[i + 1][k]) > 1) 
                        return false;
                }

                return true;
            }
        }
    }
}