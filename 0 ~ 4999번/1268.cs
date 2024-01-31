int n = int.Parse(Console.ReadLine());
var a = new int[n][];
var f = new int[n][];

for (int i = 0; i < n; i++)
{
    a[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
	f[i] = new int[n];
}

for (int k = 0; k < 5; k++)
    for (int i = 0; i < n - 1; i++)
		for (int j = i + 1; j < n; j++)
			if (i != j && a[i][k] == a[j][k])
			{
				f[i][j] = 1;
				f[j][i] = 1;
			}


var l = f.Select(i => i.Sum()).ToList();
Console.WriteLine(l.IndexOf(l.Max()) + 1);
