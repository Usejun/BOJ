using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine()), d = 0;
var a = rd.ReadLine().Split().Select(int.Parse).ToArray();
var dp = new int[n];

for (int i = 0; i < n; ++i)
{
    dp[i] = 1;
	for (int j = i - 1; j >= 0; --j)
		if (a[j] < a[i]) dp[i] = Math.Max(dp[i], dp[j] + 1);	
}

wt.Write(dp.Max());