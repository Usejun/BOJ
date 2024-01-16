int n = int.Parse(Console.ReadLine());
var dp = new long[36];
dp[0] = 1;

for (int i = 1; i < 36; i++)
	for (int j = 0; j < i; j++)
		dp[i] += dp[j] * dp[i - j - 1];

Console.Write(dp[n]);