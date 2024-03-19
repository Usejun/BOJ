var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = input[0], M = input[1];

if (N == 1)
    Console.Write(1);
else if (N == 2)
    Console.Write(Math.Min(4, (M - 1) / 2 + 1));
else if (M < 7)
    Console.Write(Math.Min(4, M));
else
    Console.Write(M - 2);