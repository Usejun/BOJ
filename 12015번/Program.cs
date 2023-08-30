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
            var ans = new List<int>();
            int n = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = 1;

            ans.Add(arr[0]);

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > ans[ans.Count - 1])
                    ans.Add(arr[i]);
                else
                {
                    index = S(arr[i]);
                    ans[index] = arr[i];
                }  
            }

            Console.WriteLine(ans.Count);

            int S(int k)
            {
                int l = 0, h = ans.Count - 1, m;
                while (l < h)
                {
                    m = l + (h - l) / 2;
                    if (ans[m] >= k) h = m;
                    else l = m + 1;
                }

                return h;
            }
        }
    }
}
