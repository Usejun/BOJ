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
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.Write(string.Join(" ", NextPremutation(array)));

            int[] NextPremutation(int[] arr)
            {
                int[] newArr = arr.ToArray();
                int pivot = -1, min = int.MaxValue, j = -1;

                for (int i = 0; i < n - 1; i++)
                    if (arr[i] < arr[i + 1])
                        pivot = i;

                if (pivot < 0)
                    return new int[] { -1 };
         
                for (int i = n - 1; i > pivot; i--)
                    if (newArr[pivot] < newArr[i])
                    {
                        (newArr[i], newArr[pivot]) = (newArr[pivot], newArr[i]);
                        break;
                    }

                for (int i = pivot + 1; i < (n + pivot + 1) / 2; i++)
                    (newArr[i], newArr[n - (i - pivot)]) = (newArr[n - (i - pivot)], newArr[i]);                      

                return newArr;              
            }
       
        } 
    }
}
