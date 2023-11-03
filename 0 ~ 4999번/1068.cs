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
            var tree = Console.ReadLine().Split().Select(int.Parse).ToList();
            int k = int.Parse(Console.ReadLine());
            int count = 0;

            Remove(k);

            for (int i = 0; i < n; i++)
            {
                bool isLeaf = true;
                if (tree[i] == -2)
                    continue;

                for (int j = 0; j < n; j++)
                    if (i == tree[j])     
                        isLeaf = false;

                if (isLeaf)
                    count++;
            }

            Console.WriteLine(count);

            void Remove(int x)
            {
                if (tree[x] == -2)
                    return;

                tree[x] = -2;
                for (int i = 0; i < n; i++)
                    if (tree[i] == x)
                        Remove(i);
            }
        }
    }
}