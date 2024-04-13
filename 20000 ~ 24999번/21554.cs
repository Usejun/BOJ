using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var a = rd.ReadLine().Split().Select(int.Parse).ToArray();
var l = new List<(int, int)>();

for (int i = 0; l.Count <= 100 && i < n; i++)
{
    if (a[i] == i + 1) continue;
	for (int j = i; j < n; j++)
		if (a[j] == i + 1)
		{
			Array.Reverse(a, i, j - i + 1);			
			l.Add((i + 1, j + 1));
		}
}

wt.WriteLine(l.Count > 100 ? -1 : l.Count);
wt.WriteLine(l.Count > 100 ? "" : string.Join("\n", l.Select(i => $"{i.Item1} {i.Item2}")));