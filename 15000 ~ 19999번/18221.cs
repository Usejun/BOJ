using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine()), d = 0;
var a = new int[n][];
(int x, int y) p = (0, 0);
(int x, int y) s = (0, 0);

for (int i = 0; i < n; i++)
{
    a[i] = rd.ReadLine().Split().Select(int.Parse).ToArray();
	for (int j = 0; j < n; j++)
	{
		if (a[i][j] == 2) s = (i, j);
		else if (a[i][j] == 5) p = (i, j);
	}
}

d = (int)Math.Sqrt(Math.Pow(s.x - p.x, 2) + Math.Pow(s.y - p.y, 2));
int maxX = Math.Max(s.x, p.x), minX = Math.Min(s.x, p.x);
int maxY = Math.Max(s.y, p.y), minY = Math.Min(s.y, p.y);
int count = 0;

for (int i = minX; i <= maxX; i++)
	for (int j = minY; j <= maxY; j++)
		if (a[i][j] == 1) count++;

wt.Write(d >= 5 && count >= 3 ? 1 : 0);