var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], k = input[2];
var b = new int[n][];
var v = new bool[n, m];
var d = new (int x, int y)[] { (0, 1), (1, 0), (0, -1), (-1, 0) };
int max = int.MinValue;

for (int i = 0; i < n; i++)
    b[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < n; i++)
	for (int j = 0; j < m; j++)	
		Solve(i, j, 1, b[i][j]);

Console.Write(max);

void Solve(int x, int y, int depth, int sum)
{
	if (depth == k)
	{
		max = Math.Max(max, sum);
		return;
	}

    v[x, y] = true;
    for (int i = x; i < n; i++)
		for (int j = 0; j < m; j++)
			if (Check(i, j))
				Solve(i, j, depth + 1, sum + b[i][j]);
	v[x, y] = false;
}

bool Check(int x, int y)
{
	if (v[x, y]) return false;

	for (int i = 0; i < 4; i++)
	{
		var dx = x + d[i].x;
		var dy = y + d[i].y;

		if (dx < 0 || dy < 0 || dx >= n || dy >= m) continue;

		if (v[dx, dy]) return false;
	}

	return true;
}