int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var d = new int[n, 2];
var max = a[0];
(d[0, 0], d[0, 1]) = (a[0], a[0]);

for (int i = 1; i < n; i++)
{
    d[i, 0] = Math.Max(d[i - 1, 0] + a[i], a[i]);
    d[i, 1] = Math.Max(d[i - 1, 0], d[i - 1, 1] + a[i]);
    max = Math.Max(max, Math.Max(d[i, 0], d[i, 1]));
}

Console.WriteLine(max);