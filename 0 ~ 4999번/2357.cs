using StreamWriter sw = new(Console.OpenStandardOutput());
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
var a = new int[n];
var t = new (int max, int min)[4*n];

for (int i = 0; i < n; i++)
    a[i] = int.Parse(Console.ReadLine());

I(0, n - 1, 1);

for (int i = 0; i < m; i++)
{
	input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	int s = input[0], e = input[1];
	var g = G(0, n - 1, s - 1, e - 1, 1);
	sw.WriteLine($"{g.min} {g.max}");
}

(int max, int min) I(int s, int e, int node)
{
    if (s == e) return t[node] = (a[s], a[s]);
    var mi = (s + e) / 2;
	var l = I(s, mi, node * 2);
	var r = I(mi + 1, e, node * 2 + 1);
    return t[node] = (Math.Max(l.max, r.max), Math.Min(l.min, r.min));
}

(int max, int min) G(int s, int e, int l, int r, int node)
{
	if (l > e || r < s) return (0, int.MaxValue);
	if (l <= s && e <= r) return t[node];
	var mi = (s + e) / 2;
	var ll = G(s, mi, l, r, 2 * node);
	var rr = G(mi + 1, e, l, r, 2 * node + 1);
    return (Math.Max(ll.max, rr.max), Math.Min(ll.min, rr.min));
}
