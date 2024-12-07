using var sw = new StreamWriter(Console.OpenStandardOutput());
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], k = input[2], MOD = 1000000007;
var a = new long[n];
var t = new long[4 * n];

for (int i = 0; i < n; i++)
	a[i] = int.Parse(Console.ReadLine());

I(0, n - 1, 1);

for (int i = 0; i < m + k; i++)
{
	input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	int o = input[0], b = input[1], c = input[2];
	
	if (o == 1) U(0, n - 1, b - 1, c, 1);
	else sw.WriteLine(P(0, n - 1, b - 1, c - 1, 1));
}

long I(int s, int e, int idx)
{
	if (s == e) return t[idx] = a[s];
	var mid = (s + e) / 2;
	return t[idx] = (I(s, mid, 2 * idx) % MOD) * (I(mid + 1, e, 2 * idx + 1) % MOD) % MOD;
}

long P(int s, int e, int l, int r, int idx)
{
	if (s > r || l > e) return 1;
	if (s >= l && e <= r) return t[idx];
	var mid = (s + e) / 2;
	return (P(s, mid, l, r, 2 * idx) % MOD) * (P(mid + 1, e, l, r, 2 * idx + 1) % MOD) % MOD;
}

long U(int s, int e, int oi, int v, int idx)
{
	if (s > oi || e < oi) return t[idx];
	if (s == e) return t[idx] = v;
	var mid = (s + e) / 2;
	return t[idx] = (U(s, mid, oi, v, 2 * idx) % MOD) * (U(mid + 1, e, oi, v, 2 * idx + 1) % MOD) % MOD ;
}
