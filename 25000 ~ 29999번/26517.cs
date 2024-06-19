int k = int.Parse(Console.ReadLine());
var p = Console.ReadLine().Split().Select(long.Parse).ToArray();
long a = p[0], b = p[1], c = p[2], d = p[3];

Console.Write(a * k + b == c * k + d ? "Yes " + (a*k+b) : "No");