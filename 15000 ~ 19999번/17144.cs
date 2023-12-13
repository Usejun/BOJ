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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dx = new int[] { 0, 0, -1, 1 };
            var dy = new int[] { 1, -1, 0, 0 };
            int r = input[0], c = input[1], t = input[2];
            var room = new int[r, c];
            var air = new (int x, int y)[2];

            for (int i = 0; i < r; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < c; j++)
                {
                    if (input[j] == -1)
                    {
                        air[0] = (i - 1, j);
                        air[1] = (i, j);
                    }
                    room[i, j] = input[j];
                }
            }

            for (int i = 0; i < t; i++)
            {
                Diffusion();

                Clockwise(air[0].x, air[0].y + 1);
                room[air[0].x, air[0].y + 1] = 0;
                room[air[0].x, air[0].y] = 0;

                AntiClockwise(air[1].x, air[1].y + 1);
                room[air[1].x, air[1].y + 1] = 0;
                room[air[1].x, air[1].y] = 0;
            }

            int sum = 0;

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    sum += room[i, j];

            Console.WriteLine(sum);

            void Diffusion()
            {
                var nextRoom = new int[r, c];

                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        if (room[i, j] < 0) continue;

                        int dust = room[i, j] / 5;
                        int count = 0;

                        for (int k = 0; k < 4; k++)
                        {
                            int nx = i + dx[k];
                            int ny = j + dy[k];

                            if (nx < 0 || nx >= r || ny < 0 || ny >= c || (nx, ny) == air[0] || (nx, ny) == air[1])
                                continue;

                            nextRoom[nx, ny] += dust;
                            count++;
                        }

                        nextRoom[i, j] += room[i, j] - dust * count;
                    }
                }
                room = nextRoom;
            }

            void Clockwise(int x, int y)
            {
                if (air[0] == (x, y))
                    return;

                if (x == air[0].x && y != c -1)
                {
                    Clockwise(x, y + 1);
                    room[x, y + 1] = room[x, y];
                }
                else if (y == c - 1 && x != 0)
                {
                    Clockwise(x - 1, y);
                    room[x - 1, y] = room[x, y];
                }
                else if (x == 0 && y != air[0].y)
                {
                    Clockwise(x, y - 1);
                    room[x, y - 1] = room[x, y];
                }
                else if (y == air[0].y)
                {
                    Clockwise(x + 1, y);
                    room[x + 1, y] = room[x, y];
                }
            }

            void AntiClockwise(int x, int y)
            {
                if (air[1] == (x, y))
                    return;

                if (x == air[1].x && y != c - 1)
                {
                    AntiClockwise(x, y + 1);
                    room[x, y + 1] = room[x, y];
                }
                else if (y == c - 1 && x != r - 1)
                {
                    AntiClockwise(x + 1, y);
                    room[x + 1, y] = room[x, y];
                }
                else if (x == r - 1 && y != air[1].y)
                {
                    AntiClockwise(x, y - 1);
                    room[x, y - 1] = room[x, y];
                }
                else if (y == air[1].y)
                {
                    AntiClockwise(x - 1, y);
                    room[x - 1, y] = room[x, y];
                }
            }
        }

    }
}