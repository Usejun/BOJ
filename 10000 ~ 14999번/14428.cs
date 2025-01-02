using var sw = new StreamWriter(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
int m = int.Parse(Console.ReadLine());
var t = new (int v, int i)[4 * n];

I(0, n - 1, 1);

for (int i = 0; i < m; i++)
{
	var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	if (input[0] == 1)
		U(0, n - 1, input[2], input[1] - 1, 1);
	else
		sw.WriteLine(G(0, n - 1, input[1] - 1, input[2] - 1, 1).i + 1);	
}

(int v, int i) I(int s, int e, int idx)
{
	if (s == e) return t[idx] = (a[s], s);
	var mid = (s + e) / 2;
	var l = I(s, mid, 2 * idx);
	var r = I(mid + 1, e, 2 * idx + 1);
	return t[idx] = l.v < r.v ? l : l.v > r.v ? r : (l.v, Math.Min(l.i, r.i));
}

(int v, int i) G(int s, int e, int l, int r, int idx)
{
	if (s > r || e < l) return (int.MaxValue, int.MaxValue);
	if (l <= s && e <= r) return t[idx];
	var mid = (s + e) / 2;
	var lv = G(s, mid, l, r, 2 * idx);
	var rv = G(mid + 1, e, l, r, 2 * idx + 1);
	return lv.v < rv.v ? lv : lv.v > rv.v ? rv : lv.i < rv.i ? lv : rv;
}

(int v, int i) U(int s, int e, int v, int i, int idx)
{
	if (i < s || i > e) return t[idx];
	if (s == e) return t[idx] = (v, i);
	var mid = (s + e) / 2;
	var lv = U(s, mid, v, i, 2 * idx);
	var rv = U(mid + 1, e, v, i, 2 * idx + 1);
	return t[idx] = lv.v < rv.v ? lv : lv.v > rv.v ? rv : lv.i < rv.i ? lv : rv;
}
