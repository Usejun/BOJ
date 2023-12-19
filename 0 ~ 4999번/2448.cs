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
        var sw = new StreamWriter(Console.OpenStandardOutput());
        int n = int.Parse(Console.ReadLine());        
        var buf = new char[n, n * 2];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n * 2; j++)
                buf[i, j] = ' ';          

        Triangle(n, 0, n);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 2 - 1; j++)
                sw.Write(buf[i, j]);
            sw.WriteLine();
        }
        sw.Close();

        void Write(int x, int y)
        {
            buf[x, y - 1] = '*';

            buf[x + 1, y - 2] = '*';
            buf[x + 1, y] = '*';

            buf[x + 2, y - 3] = '*';
            buf[x + 2, y - 2] = '*';
            buf[x + 2, y - 1] = '*';
            buf[x + 2, y] = '*';   
            buf[x + 2, y + 1] = '*';
        }

        void Triangle(int size, int x, int y)
        {
            if (size == 1) return;
            if (size == 3) Write(x, y);

            Triangle(size / 2, x, y);
            Triangle(size / 2, x + size / 2, y + size / 2);
            Triangle(size / 2, x + size / 2, y - size / 2);
        }
    }
}