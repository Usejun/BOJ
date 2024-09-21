int n = int.Parse(Console.ReadLine()), MAX = 10001;
var dp = Enumerable.Repeat(1, MAX).ToArray();

for (int i = 2; i < MAX; i++)
	dp[i] += dp[i - 2];

for (int i = 3; i < MAX; i++)
	dp[i] += dp[i - 3];

while (n-- > 0) Console.WriteLine(dp[int.Parse(Console.ReadLine())]);
