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
            var tree = new int[n];
            var dis = new int[n - 1];
            int count = 0;

            for (int i = 0; i < n; i++)
                tree[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
                dis[i] = tree[i + 1] - tree[i];

            int k = dis[0];

            for (int i = 1; i < n - 1; i++)
                k = Gcd(k, dis[i]);

            for (int i = 0; i < n - 1; i++)
                count += (dis[i] / k) - 1;

            Console.Write(count);

            int Gcd(int a, int b) => a % b == 0 ? b : Gcd(b, a % b);
        }
    }
}
