using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var a = rd.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 2; i < n - 1; i++)
    if (a[0] >= a[n - 1]) a[0]--;
    else a[n - 1]--;
a[0]--; a[n - 1]--;

wt.Write(Math.Max(a[0], a[n - 1]));