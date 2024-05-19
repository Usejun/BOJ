using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine()), k = 0, c = 1;
var a = new List<(int x, int l)>();

for (int i = 0; i < n; i++)
{
    var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
    a.Add((input[0], input[1]));
}

a.Sort((i, j) => i.x.CompareTo(j.x));

for (int i = 0; i < n - 1; i++)
    if (a[i].x + a[i].l < a[i + 1].x) c++;

wt.Write(c);