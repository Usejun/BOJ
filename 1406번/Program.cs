using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingTest
{
    internal class Program
    {
        static void Main()
        {
            var n = new LinkedListNode<char>('0');
            var l = new LinkedList<char>(Console.ReadLine().ToCharArray());
            var sb = new StringBuilder(); 
            var N = int.Parse(Console.ReadLine());
            l.AddLast(n);
            while (N-- > 0)
            {
                var c = Console.ReadLine();
                if (c[0] == 'L') n = n.Previous ?? n;
                if (c[0] == 'D') n = n.Next ?? n;
                if (c[0] == 'B' && n.Previous != null) l.Remove(n.Previous);
                if (c[0] == 'P') l.AddBefore(n, c[2]);
            }
            sb.Append(string.Join("", l.TakeWhile(x => x != '0')));
            Console.Write(sb);
        }
    }
}
