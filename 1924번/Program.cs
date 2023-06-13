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
            int[] now = Console.ReadLine().Split().Select(int.Parse).ToArray();
            DateTime date = new DateTime(2007, now[0], now[1]);
            
            Console.Write(date.DayOfWeek.ToString().Substring(0,3).ToUpper());
        }
    }
}
