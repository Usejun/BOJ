int n = int.Parse(Console.ReadLine());
var l = new List<int>();
var v = Enumerable.Repeat(1, n).ToArray();

for (int i = 0; i < n; i++)
{
	l.Add(int.Parse(Console.ReadLine()));
	for (int j = i-1; j >= 0; j--)	
		if (l[i] > l[j])
			v[i] = Math.Max(v[j] + 1, v[i]);		
}

Console.Write(n - v.Max());
