using System;
using System.Linq;

namespace Boj
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            int n, count;
            int[,] friend;
            bool[,] visit;

            Input();
            Solve();

            void Input()
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                n = input[0];
                count = input[1];
                friend = new int[n, n];
                visit = new bool[n, n];

                for (int i = 0; i < count; i++)
                {
                    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    int x = input[0] - 1, y = input[1] - 1;

                    friend[x, y] = 1;
                    friend[y, x] = 1;
                }

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (friend[i, j] == 0)
                            friend[i, j] = 10000;
            }

            void Solve()
            {
                Floyd();

                int number = -1;
                int min = int.MaxValue;

                for (int i = 0; i < n; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < n; j++)
                        if (i != j)
                            sum += friend[i, j];
                    if (sum < min)
                    {
                        min = sum;
                        number = i + 1;
                    }               
                }

                Console.WriteLine(number);
            }

            void Floyd()
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        for (int k = 0; k < n; k++)
                            friend[j, k] = Math.Min(friend[j, k], friend[j, i] + friend[i, k]);
            }
        }
    }
}
