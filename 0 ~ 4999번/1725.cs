int n = int.Parse(Console.ReadLine());
var a = new int[n];
for (int i = 0; i < n; i++)
	a[i] = int.Parse(Console.ReadLine());
Console.Write(Max(0, n - 1));

long Max(long s, long e)
{
	if (s == e) return a[s];
	long m = (s + e) / 2, l = m, r = m + 1, h = int.MaxValue, w = a[r];
	
	while (l >= s && r <= e)
	{
		h = Math.Min(h, Math.Min(a[l], a[r]));
		w = Math.Max(w, h * (r - l + 1));
		if (l == s) r++;
		else if (r == e) l--;
		else if (a[l - 1] < a[r + 1]) r++;
		else l--;
	}
	return Math.Max(Math.Max(Max(s, m), Max(m + 1, e)), w);
} 
