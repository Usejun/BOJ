using StreamWriter w = new(Console.OpenStandardOutput());
int N = 100001, MOD = 1000000009;
var dp = new long[100001, 4];

dp[1, 1] = 1;
dp[2, 2] = 1;
dp[3, 1] = 1;
dp[3, 2] = 1;
dp[3, 3] = 1;

for (int i = 4; i < N; i++)
{ 
    dp[i, 1] = (dp[i - 1, 2] + dp[i - 1, 3]) % MOD;
    dp[i, 2] = (dp[i - 2, 1] + dp[i - 2, 3]) % MOD;
    dp[i, 3] = (dp[i - 3, 1] + dp[i - 3, 2]) % MOD;
}

int n = int.Parse(Console.ReadLine());

while (n-- > 0)
    w.WriteLine(Sum(int.Parse(Console.ReadLine())));

long Sum(int k) => (dp[k, 1] + dp[k, 2] + dp[k, 3]) % MOD;