int n = int.Parse(Console.ReadLine());
var a = Enumerable.Range(0, n).Select(i => Console.ReadLine().Split().Select(int.Parse).ToArray()).ToArray();
var dp = new int[n, n];
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };
int max = 0;

for (int i = 0; i < n; i++)
	for (int j = 0; j < n; j++)
		max = Math.Max(max, DFS(i, j, 0));

Console.Write(max);

int DFS(int x, int y, int depth)
{
	if (dp[x, y] != 0) return dp[x, y];
	dp[x, y] = 1;
	for (int i = 0; i < 4; i++)
	{
		int dx = x + d[i].x;
		int dy = y + d[i].y;

		if (dx < 0 || dx >= n || dy < 0 || dy >= n || a[dx][dy] <= a[x][y]) continue;

		dp[x, y] = Math.Max(dp[x, y], DFS(dx, dy, depth + 1) + 1);
	}
	return dp[x, y];
}