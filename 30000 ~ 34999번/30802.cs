int n = int.Parse(Console.ReadLine());
var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
double t = input[0], p = input[1];

Console.WriteLine(size.Select(i => Math.Ceiling(i / t)).Sum());
Console.Write($"{Math.Floor(n / p)} {n % p}");
