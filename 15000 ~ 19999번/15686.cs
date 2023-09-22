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
            var map = new int[n][];
            var isUsed = new bool[n, n];
            var chickenDir = new List<(int, int)>();
            var houseDir = new List<(int, int)>();
            int result = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                    if (input[j] == 1)
                        houseDir.Add((j, i));
                    else if (input[j] == 2)
                        chickenDir.Add((j, i));
            }

            for (int i = 0; i < chickenDir.Count; i++)
            {
                (int x, int y) = chickenDir[i];
                if (!isUsed[y, x])
                {
                    isUsed[y, x] = true;
                    CityChicken(i, 1);
                    isUsed[y, x] = false;
                }
            }

            Console.WriteLine(result);

            void CityChicken(int start, int count)
            {
                if (count == m)
                {
                    CheckAllHouseDis();
                    return;
                }

                for (int i = start; i < chickenDir.Count; i++)
                {
                    (int x, int y) = chickenDir[i];
                    if (!isUsed[y, x])
                    {
                        isUsed[y, x] = true;
                        CityChicken(i, count + 1);
                        isUsed[y, x] = false;
                    }
                }
            }
          
            void CheckAllHouseDis()
            {
                int sum = 0;

                for (int i = 0; i < houseDir.Count; i++)
                {
                    (int hx, int hy) = houseDir[i];
                    int dis = int.MaxValue;
                    for (int j = 0; j < chickenDir.Count; j++)
                    {
                        (int cx, int cy) = chickenDir[j];
                        if (isUsed[cy, cx])
                            dis = Math.Min(dis, Math.Abs((hy + 1) - (cy + 1)) + Math.Abs((hx + 1) - (cx + 1)));
                    }

                    sum += dis;
                }
                result = Math.Min(result, sum);
            }
        }
    }
}
