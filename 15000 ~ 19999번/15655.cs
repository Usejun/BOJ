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
            StringBuilder sb = new StringBuilder();
            int n, length;            
            int[] array, buffer, input;            

            Input();
            Solve();

            Console.WriteLine(sb);

            void Input()
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                n = input[0];
                length = input[1];
                array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                buffer = new int[length];
            }

            void Solve()
            {
                Array.Sort(array);

                Dfs(0, 0);
            }

            void Dfs(int start, int depth)
            {
                if (depth == length)
                {
                    sb.AppendLine(string.Join(" ", buffer));
                    return;
                }

                for (int i = start; i < n; i++)
                {
                    buffer[depth] = array[i];
                    Dfs(i + 1, depth + 1);
                }               
            }
        }
    }
}
