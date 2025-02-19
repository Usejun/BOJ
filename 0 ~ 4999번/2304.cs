int n = int.Parse(Console.ReadLine());
var a = new List<(int L, int H)>();

for (int i = 0; i < n; i++)
{
	var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	int x = input[0], y = input[1];
	a.Add((x, y));
}

a.Sort((i, j) => i.L.CompareTo(j.L));
int idx = a.IndexOf(a.MaxBy(i => i.H)), v = 0, h = a[0].H;

for (int i = 0; i < idx; i++) 
{
	v += h * (a[i + 1].L - a[i].L);
	h = Math.Max(h, a[i + 1].H);
}

h = a[^1].H;
for (int i = n-1; i > idx; i--) 
{
	v += h * (a[i].L - a[i - 1].L);
	h = Math.Max(h, a[i-1].H);
}

Console.Write(v+a[idx].H);
