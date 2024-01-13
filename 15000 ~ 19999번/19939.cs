var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], k = input[1], s = (1 + k) * k / 2;
Console.WriteLine((1 + k) * k / 2 > n ? -1 : (n - s) % k == 0 ? k - 1 : k);
