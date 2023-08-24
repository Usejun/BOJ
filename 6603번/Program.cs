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
            int[] array, buffer = new int[6];
            bool[] visit;
            StringBuilder sb = new StringBuilder();

            Input();

            Console.WriteLine(sb);

            void Input()
            {  
                while (true)
                {
                    array = Console.ReadLine().Split().Select(int.Parse).ToArray();

                    if (array.Length == 1)
                        break;

                    visit = new bool[array[0]];

                    Dfs(1, 0);

                    sb.AppendLine();
                }
            }
            
            void Dfs(int start, int depth)
            {
                if (depth == 6)
                {
                    sb.AppendLine(string.Join(" ", buffer));
                    return;
                }

                for (int i = start; i <= array[0]; i++)
                {
                    buffer[depth] = array[i];
                    Dfs(i + 1, depth + 1);
                }   
            }
        }
    }
}
