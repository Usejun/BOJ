using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Trim().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
var p = new List<int[]>();
var c = true;

for (int i = 0; i < n; i++)
    p.Add(rd.ReadLine().Split().Select(int.Parse).ToArray());

p = p.OrderBy(i => i.Sum()).ToList();

for (int i = 1; c && i < n; i++)
	for (int j = 0; c && j < m; j++)
		if (p[i - 1][j] == 1 && p[i][j] == 0)		
			c = false;

wt.Write(c ? "YES" : "NO");