using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {     
        static void Main(string[] args)            
        {
            int n = int.Parse(Console.ReadLine());
            var maps = new int[n, n];
            var visitied = new bool[n, n];
            var group = new int[n * n];
            var q = new Queue<(int, int)>();

            int number = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                    maps[i, j] = input[j] - '0';
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (!visitied[i, j] && maps[i, j] == 1)
                    {
                        number++;
                        Dfs(i, j);
                    }

            Array.Sort(group, 0, number);
            Console.WriteLine(number);
            for (int i = 0; i < number; i++)            
                Console.WriteLine(group[i]);
            
            void Dfs(int y, int x)
            {
                if (x < 0 || y < 0 || x >= n || y >= n || visitied[y, x] || maps[y, x] == 0)
                    return;

                visitied[y, x] = true;
                group[number - 1]++;
                maps[y, x] = number;

                Dfs(y - 1, x);
                Dfs(y + 1, x);
                Dfs(y, x - 1);
                Dfs(y, x + 1);
            }
        }
    }
}
