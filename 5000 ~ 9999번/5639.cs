using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;

namespace Boj
{
    public class Program
    {
        public class Node
        {
            public static System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int value = 0;
            Node left;
            Node right;

            public Node(int value)
            {
                this.value = value; 
            }

            public void Print()
            {
                left?.Print();
                right?.Print();
                sb.Append($"{value}\n");            
            }

            public void Add(Node node)
            {
                if (value > node.value)
                {
                    if (left != null) left.Add(node);
                    else left = node;
                }
                else
                {
                    if (right != null) right.Add(node);
                    else right = node;
                }

            }
        }

        public static void Main(string[] arg)
        {
            Node tree = null;
            try
            {
                int n = -1;

                while (true)
                {
                    n = int.Parse(Console.ReadLine());
                    Node node = new Node(n);
                    if (tree == null) tree = node;
                    else tree.Add(node);
                }                
            }
            catch { }
            finally
            {
                tree.Print();
                Console.Write(Node.sb);
            }

        }
    }
}