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
            var set = new HashSet<string>();
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                if (name == "ENTER")
                {
                    count += set.Count;
                    set.Clear();
                }
                else set.Add(name);
            }

            count += set.Count;

            Console.WriteLine(count);
        }
    }
}