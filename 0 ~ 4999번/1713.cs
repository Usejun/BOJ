int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var c = new int[101];
var l = new List<int>();

foreach (var i in a) 
{
	c[i]++;
	if (l.Contains(i)) continue;
	if (l.Count == n)
	{		
		var v = -1;
		for (int k = n - 1; k >= 0; k--)
			if (v == -1 || c[v] > c[l[k]])
				v = l[k];
		var j = l.FindIndex(k => c[k] == c[v]);
		c[l[j]] = 0;
		l.RemoveAt(j);	
	}
	l.Add(i);
}

Console.Write(string.Join(" ", l.OrderBy(i => i)));
