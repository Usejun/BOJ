int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var b = a.Sum();
long c = 0;

for (int i = 0; i < n; i++)
    c += a[i] * (b -= a[i]);

Console.Write(c);