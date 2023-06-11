using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace Boj
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            int sum = 1;
            int[] nums = new int[10];

            for (int i = 0; i < 3; i++)
            {
                sum *= int.Parse(Console.ReadLine());
            }

            while (true)
            {
                nums[sum % 10]++;
                sum /= 10;
                if (sum < 10)
                {
                    nums[sum]++;
                    break;
                }
            }

            Console.WriteLine(string.Join("\n", nums));

        }
    }    
}
