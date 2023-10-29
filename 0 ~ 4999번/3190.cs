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
            var snake = new Queue<(int x, int y)>();
            var move = new Dictionary<int, string>();
            var dx = new int[] { 0, 1, 0, -1 }; 
            var dy = new int[] { 1, 0, -1, 0 };
            int dir = 0;
            int count = 1;

            int n = int.Parse(Console.ReadLine());
            var map = new int[n, n];
            int k = int.Parse(Console.ReadLine());
            (int x, int y) head = (0, 0);
            snake.Enqueue(head);

            for (int i = 0; i < k; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                map[input[0] - 1, input[1] - 1] = 1;
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine().Split();
                move.Add(int.Parse(input[0]), input[1]);
            }

            while (true)
            {
                head.x += dx[dir];
                head.y += dy[dir];
                if (head.x >= n || head.y >= n || head.x < 0 || head.y < 0 || snake.Contains(head))
                    break;

                snake.Enqueue(head);
                if (map[head.x, head.y] == 0) snake.Dequeue();
                else map[head.x, head.y] = 0;

                if (move.ContainsKey(count))
                    dir = move[count] == "D" ? (dir + 1) % 4 : (dir + 3) % 4;

                count++;
            }

            Console.WriteLine(count);
        }
    }
}