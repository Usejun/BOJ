using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
long n = long.Parse(rd.ReadLine()), MOD = 1000000007;
var dp = new long[1000001];
wt.Write(Fib(n) % MOD);

long Fib(long k) => k == 0 ? 0 : k < 2 ? 1 : dp[k] != 0 ? dp[k] : dp[k] = ((Fib(k - 2) % MOD) + (Fib(k - 1) % MOD)) % MOD;