int n = int.Parse(Console.ReadLine());
var a = new int[n][];
var dp = Enumerable.Repeat(99999, 1<<21).ToArray();;

for (int i = 0; i < n; i++)
    a[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.Write(DFS(0, 0));
	
int DFS(int k, int v)
{
	if (v == (1 << n) - 1) return 0;
	if (dp[v] != 99999) return dp[v];
	for (int i = 0; i < n; i++)
		if ((v & (1 << i)) == 0)
			dp[v] = Math.Min(dp[v], DFS(k + 1, v | (1 << i)) + a[k][i]);
	return dp[v];
}
