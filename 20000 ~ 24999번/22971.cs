using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine()), MOD = 998244353;
var a = rd.ReadLine().Split().Select(int.Parse).ToArray();
var dp = new long[10001];
dp[0] = 1;
wt.Write(1 + " ");
for (int i = 1; i < n; i++)
{
	dp[i] = 1;
	for (int j = 0; j < i; j++)
		if (a[i] > a[j])
		{
			dp[i] += dp[j];
			dp[i] %= MOD;
		}
	wt.Write(dp[i] + " ");
}