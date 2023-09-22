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
      static void Main(string[] args)
      {
          var sb = new StringBuilder();
          int n = int.Parse(Console.ReadLine());
          for (int i = 0; i < n; i++)
          {
              var isReverse = false;
              var isError = false;
              var command = Console.ReadLine().ToCharArray();
              int length = int.Parse(Console.ReadLine());
              var array = new List<string>();
              var input = Console.ReadLine().Trim('[', ']').Split(',');
              var q = new Queue<string>();
              if (length != 0)
                  q = new Queue<string>(input);
              for (int j = 0; j < command.Length; j++)
              {
                  if (command[j] == 'R')
                      isReverse = !isReverse;                                                                
                  else
                  {
                      if (q.Count == 0 || length == 0)
                      {
                          isError = true;
                          break;
                      }
                      if (isReverse)
                          length--;
                      if (!isReverse)
                      {
                          length--;
                          q.Dequeue();
                      }
                  }
              }
              if (isError || length < 0)
              {
                  sb.AppendLine("error");
                  continue;
              }
              sb.Append('[');
              while (length-- > 0 && q.Count != 0)
                      array.Add(q.Dequeue());
              if(isReverse)
                  array.Reverse();
              sb.Append(string.Join(",", array)).Append(']').Append('\n');
          }
          Console.Write(sb);
      }
  }
}
  
