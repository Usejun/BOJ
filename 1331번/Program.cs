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
            bool[,] visit = new bool[6, 6];
            int x, y;

            string first = Console.ReadLine();
            x = first[0] - 'A';
            y = first[1] - '1';

            visit[y, x] = true;

            for (int i = 0; i < 35; i++)
            {
                string next = Console.ReadLine();
                int nx = next[0] - 'A';
                int ny = next[1] - '1';

                if (Check(x, y, nx, ny))
                {
                    y = ny;
                    x = nx;
                }
                else
                {
                    Console.WriteLine("Invalid");
                    return;
                }

                visit[y, x] = true;
            }

            if (Check(x, y, first[0] - 'A', first[1] - '1'))
            {
                for (int i = 0; i < 6; i++)             
                    for (int j = 0; j < 6; j++)                 
                        if (!visit[i, j])
                        {
                            Console.WriteLine("Invalid");
                            return;
                        }
            }
            else
            {
                Console.WriteLine("Invalid");
                return;
            }

            Console.WriteLine("Valid");          

            bool Check(int x1, int y1, int x2, int y2)
            {
                int dx = Math.Abs(x1 - x2);
                int dy = Math.Abs(y1 - y2);

                if ((dx == 1 && dy == 2) || (dx == 2 && dy == 1))
                    return true;
                return false;                              
            }
        }
    }
}
