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
            var sb = new StringBuilder();
            var r = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int n = int.Parse(r.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(r.ReadLine());
            Array.Sort(arr);
            foreach (int i in arr)
                sb.Append(i).Append('\n');
            using (var w = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())))
                w.Write(sb.ToString());
        }
    }
}
    
