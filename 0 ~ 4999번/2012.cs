int n = int.Parse(Console.ReadLine());
long k = 0;
var r = new List<int>();

for (int i = 0; i < n; i++)
    r.Add(int.Parse(Console.ReadLine()));
r.Sort();

for (int i = 0; i < n; i++)
    k += Math.Abs(i + 1 - r[i]);

Console.Write(k);