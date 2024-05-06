using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
int m = int.Parse(rd.ReadLine());
var a = rd.ReadLine().Split().Select(int.Parse).ToArray();
int k = a[0] - 0;

for (int i = 1; i < m; i++)
    k = Math.Max(k, (int)((a[i] - a[i - 1]) / 2.0 + 0.5));
k = Math.Max(k, n - a[m - 1]);

wt.Write(k);