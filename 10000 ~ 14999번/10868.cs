using var sw = new StreamWriter(Console.OpenStandardOutput());
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
var a = new int[n];
var t = new int[4 * n];

for (int i = 0; i < n; i++)
	a[i] = int.Parse(Console.ReadLine());

I(0, n - 1, 1);

for (int i = 0; i < m; i++)
{
	input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	sw.WriteLine(G(0, n - 1, input[0] - 1, input[1] - 1, 1));
}

int I(int s, int e, int idx)
{
	if (s == e) return t[idx] = a[s];
	var mid = (s + e) / 2;
	return t[idx] = Math.Min(I(s, mid, 2 * idx), I(mid + 1, e, 2 * idx + 1));
}

int G(int s, int e, int l, int r, int idx)
{
	if (s > r || e < l) return int.MaxValue;
	if (l <= s && e <= r) return t[idx];
	var mid = (s + e) / 2;
	return Math.Min(G(s, mid, l, r, 2 * idx), G(mid + 1, e, l, r, 2 * idx + 1));
}
