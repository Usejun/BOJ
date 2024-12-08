int n = int.Parse(Console.ReadLine()), MAX = 987654321;
var a = new int[n][];
var dp = new int[n][];

for (int i = 0; i < n; i++)
	dp[i] = Enumerable.Repeat(-1, 1 << n).ToArray();

for (int i = 0; i < n; i++)
	a[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.Write(DFS(0, 1));

int DFS(int k, int v)
{	
	if (v == (1 << n) - 1) return a[k][0] == 0 ? MAX : a[k][0];
	if (dp[k][v] != -1) return dp[k][v];
	dp[k][v] = MAX;
	for (int i = 0; i < n; i++)	
		if ((v & (1 << i)) == 0 && a[k][i] != 0) 
			dp[k][v] = Math.Min(dp[k][v], a[k][i] + DFS(i, v | (1 << i)));
	return dp[k][v];
}
