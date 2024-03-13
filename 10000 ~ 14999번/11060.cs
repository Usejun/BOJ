int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var dp = Enumerable.Repeat(1010, n).ToArray();

dp[0] = 0;
for (int i = 0; i < n; i++)
    for (int j = 1; j <= a[i]; j++)
        if (i + j < n) dp[i + j] = Math.Min(dp[i + j], dp[i] + 1);
        
Console.Write(dp[^1] == 1010 ? -1 : dp[^1]);