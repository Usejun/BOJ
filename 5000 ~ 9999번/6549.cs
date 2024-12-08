using var sw = new StreamWriter(Console.OpenStandardOutput());
int[] a;
string input;

while ((input = Console.ReadLine()) != "0")
{
	a = input.Split().Select(int.Parse).ToArray();
	int n = a.Length;
	sw.WriteLine(Max(1, n-1));
}

long Max(int s,  e)
{
	if (s == e) return a[s];
	int m = (s + e) / 2, l = m, r = m + 1, h = int.MaxValue, w = a[r];
	
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
