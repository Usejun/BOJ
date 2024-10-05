int k = int.Parse(Console.ReadLine()), N = 1000000, M = 1000000000;
var dp = new int[N + 1];
Console.Write($"{(k == 0 ? 0 : k > 0 ? 1 : k % 2 == 0 ? -1 : 1)}\n{DP(Math.Abs(k)) % M}");
int DP(int k) => dp[k] != 0 ? dp[k] : k < 2 ? dp[k] = k : dp[k] = (DP(k - 2) % M) + (DP(k - 1) % M) % M;
