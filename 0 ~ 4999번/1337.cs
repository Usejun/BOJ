int n = int.Parse(Console.ReadLine()), k = 4;
var l = new List<int>();

for (int i = 0; i < n; i++)
    l.Add(int.Parse(Console.ReadLine()));

l.Sort();

for (int i = 0; i < n; ++i)
	for (int j = n - 1; j > i; --j)
		if (l[j] - l[i] <= 4)
			k = Math.Min(k,4-(j-i));

Console.WriteLine(k);
