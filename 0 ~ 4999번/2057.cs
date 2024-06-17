long n = long.Parse(Console.ReadLine()), k = n;
var a = new List<long>() { 1 };
for (int i = 1; a[^1] <= n; ++i)
    a.Add(a[^1] * i);

for (int i = a.Count-1; i >= 0; --i)
    if (a[i] <= k) k -= a[i];

Console.Write(n != 0 && k == 0 ? "YES" : "NO");