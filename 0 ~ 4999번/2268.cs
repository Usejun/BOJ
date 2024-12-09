using var w = new StreamWriter(Console.OpenStandardOutput());
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], MAX = 1000000;
var a = new int[MAX];
var t = new long[4 * MAX + 10];

for (int i = 0; i < m; i++)
{
	input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	int o = input[0], v1 = input[1], v2 = input[2];
	
	if (o == 1) 
	{
		U(0, n - 1, -(a[v1 - 1] - v2), v1 - 1, 1);
		a[v1 - 1] = v2;
	}
	else w.WriteLine(S(0, n - 1, Math.Min(v1, v2) - 1, Math.Max(v1, v2) - 1, 1));
}

long S(int s, int e, int l, int r, int idx)
{
	if (s > r || e < l) return 0;
	if (s >= l && e <= r) return t[idx];
	var mid = (s + e) / 2;
	return S(s, mid, l, r, 2 * idx) + S(mid + 1, e, l, r, 2 * idx + 1);
}

void U(int s, int e, long d, int i, int idx)
{
	if (i < s || i > e) return;
	t[idx] += d;
	if (s == e) return;
	var mid = (s + e) / 2;
	U(s, mid, d, i, 2 * idx);
	U(mid + 1, e, d, i, 2 * idx + 1);
}
