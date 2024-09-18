int n = int.Parse(Console.ReadLine());
var l = new List<int>();
HashSet<int> a = new(), b = new(), c = new();

for (int i = 0; i < n; i++)
	l.Add(int.Parse(Console.ReadLine()));

for (int i = 0; i < n; i++)
{
	a.Clear();
	b.Clear();
	DFS(i);
	
	if (Equals(a, b))
		foreach(int x in a)		
			c.Add(x);
}

Console.Write($"{c.Count}\n{string.Join("\n", c.OrderBy(i => i))}");

bool Equals(HashSet<int> x, HashSet<int> y)
{
	if (x.Count != y.Count) return false;
	
	foreach (int e in x)
		if (!y.Contains(e)) return false;
	
	return true;	
}

void DFS(int k)
{
	if (!b.Contains(k+1))
	{
		a.Add(l[k]);
		b.Add(k+1);
		DFS(l[k]-1);
	}
}
