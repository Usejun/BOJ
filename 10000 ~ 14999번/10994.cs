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
            var sb = new System.Text.StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int size = 4 * (n - 1) + 1;
            var a = new char[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    a[i, j] = ' ';

            Draw(0, 0, size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    sb.Append(a[i, j]);
                sb.Append('\n');
            }

            Console.WriteLine(sb);

            void Draw(int x, int y, int len)
            {
                for (int i = 0; i < len; i++)
                {
                    a[x, y + i] = '*';
                    a[x + i, y] = '*';
                    a[x + len - 1, y + i] = '*';
                    a[x + i, y + len - 1] = '*';
                }

                if (len > 1) Draw(x + 2, y + 2, len - 4);
            }
        }
    }
}