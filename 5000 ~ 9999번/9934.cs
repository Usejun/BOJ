int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var b = new List<int>[n];

for (int i = 0; i < n; i++)
	b[i] = new List<int>();

S(0, (1 << n) - 1, 0);

Console.Write(string.Join("\n", b.Select(l => string.Join(" ", l))));

void S(int l, int r, int d)
{
	var m = (l + r) / 2;
	if (l != r)
	{
		b[d].Add(a[m]);
		S(l, m, d + 1);
		S(m + 1, r, d + 1);
	}
}
