var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
long n = input[0], p = input[1], q = input[2];
var d = new Dictionary<long, long>();
Console.Write(DP(n));

long DP(long k)
{
	if (k == 0) return d[0] = 1;
	if (d.TryGetValue(k, out long v)) return v;
	return d[k] = DP(k/p) + DP(k/q);
}
