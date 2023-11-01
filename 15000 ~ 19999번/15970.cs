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
            var points = new (int x, int y)[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                points[i] = (input[0], input[1]);
            }

            points = points.OrderBy(i => i.y).ThenBy(i => i.x).ToArray();

            for (int i = 0; i < n; i++)
            {
                if (i == 0 && points[i + 1].y == points[i].y) sum += Math.Abs(points[i + 1].x - points[i].x);
                else if (i == n - 1 && points[i - 1].y == points[i].y) sum += Math.Abs(points[i - 1].x - points[i].x);
                else
                {
                    (int x1, int y1) = points[i - 1];
                    (int x2, int y2) = points[i + 1];

                    sum += Math.Min((y1 == points[i].y ? Math.Abs(x1 - points[i].x) : int.MaxValue), (y2 == points[i].y ? Math.Abs(x2 - points[i].x) : int.MaxValue));
                }
            }

            Console.WriteLine(sum);
        }
    }
}