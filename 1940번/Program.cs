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
            int m = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            int left = 0, right = array.Length - 1, count = 0;
            while (left != right)
            {
                int sum = array[left] + array[right];
                if (sum == m)
                {
                    count++;
                    left++;
                }
                else if (sum > m)
                    right--;
                else if (sum < m)
                    left++;
            }
            Console.WriteLine(count);
        }
    }
}
    
