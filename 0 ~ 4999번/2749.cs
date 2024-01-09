int l = 1500000, MOD = 1000000;
var dp = new int[l];
dp[0] = 0; dp[1] = 1;

for (int i = 2; i < l; i++)
    dp[i] = (dp[i - 1] + dp[i - 2]) % MOD;

Console.WriteLine(dp[long.Parse(Console.ReadLine()) % l]);
