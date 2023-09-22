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
            var board = new List<List<int>>();
            var number = new List<int>();
            int count = 0;

            for (int i = 0; i < 5; i++)
                board.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
            for (int i = 0; i < 5; i++)
                number = number.Concat(Console.ReadLine().Split().Select(int.Parse)).ToList();

            while (true)
            {
                int now = number[count];
                int line = 0;

                board.ForEach(row =>
                {
                    if (row.Contains(now))
                        row[row.IndexOf(now)] = 0;
                });
                line += Enumerable.Range(0, 5).Select(n => board[n].Sum(y => y)).Count(x => x == 0);
                line += Enumerable.Range(0, 5).Select(col => board.Sum(row => row[col])).Count(x => x == 0);
                line += Enumerable.Range(0, 5).Select(n => board[n][n]).Sum() == 0 ? 1 : 0;
                line += Enumerable.Range(0, 5).Select(n => board[n][4 - n]).Sum() == 0 ? 1 : 0;

                if (line >= 3)
                    break;
                count++;
                
            }
            Console.WriteLine(count + 1);
        }
    }
}
    
