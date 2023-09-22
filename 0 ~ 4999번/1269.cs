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
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var f = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));
            var s = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine(f.Except(s).Count() + s.Except(f).Count());
        }
    }
}
