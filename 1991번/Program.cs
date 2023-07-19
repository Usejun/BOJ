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
        public class Node
        {
            public string data;
            public Node left;
            public Node right;

            public Node(string data)
            {
                this.data = data;
            }

            public void Preorder()
            {
                Console.Write(data);
                left?.Preorder();
                right?.Preorder();
            }

            public void Inorder()
            {
                left?.Inorder();
                Console.Write(data);
                right?.Inorder();
            }

            public void Postorder()
            {
                left?.Postorder();
                right?.Postorder();
                Console.Write(data);
            }

        }

        static void Main(string[] args)            
        {
            var node = new Dictionary<string, Node>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 27; i++)
                node[((char)(i + 'A')).ToString()] = new Node(((char)(i + 'A')).ToString());
            node["."] = new Node("");
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                node[input[0]].left = node[input[1]];
                node[input[0]].right = node[input[2]];
            }

            node["A"].Preorder();
            Console.WriteLine();
            node["A"].Inorder();
            Console.WriteLine();
            node["A"].Postorder();
        }       
    }
}
    
