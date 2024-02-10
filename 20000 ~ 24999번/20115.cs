int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(double.Parse).OrderBy(i=>i).ToArray();
Console.Write(a.Take(n - 1).Sum() / 2 + a[n - 1]);

