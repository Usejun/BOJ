int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var dp = Enumerable.Repeat(1, n).ToArray();

for (int i = 0; i < n - 1; i++)
    for (int j = i + 1; j < n; j++)
        dp[j] = a[i] < a[j] ? Math.Max(dp[i] + 1, dp[j]) : dp[j];

Console.Write(dp.Max());