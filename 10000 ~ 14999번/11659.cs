using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;

namespace Boj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(Console.OpenStandardInput());
            var sb = new StringBuilder();
            var data = sr.ReadLine().Split().Select(int.Parse).ToArray();
            var array = sr.ReadLine().Split().Select(int.Parse).ToArray();
            var sumList = new List<int>() { 0 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                sumList.Add(sum);
            }
            Console.WriteLine(string.Join(" ", sumList));
            for (int i = 0; i < data[1]; i++)
            { 
                var input = sr.ReadLine().Split().Select(int.Parse).ToArray();
                sb.Append(sumList[input[1]] - sumList[input[0]-1] + "\n");
            }
            Console.Write(sb);

        }
    }
}
