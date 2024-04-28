using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int t = int.Parse(rd.ReadLine());
long[] dp;
for (int i = 0; i < t; i++)
{
    var input = rd.ReadLine().Split().Select(long.Parse).ToArray();
    long p = input[0], q = input[1];
    dp = new long[p + 1];
    
    wt.WriteLine($"Case #{i + 1}: {Fib(p) % p}");

    long Fib(long k) => k <= 2 ? (dp[k] = 1) : dp[k] == 0 ? (dp[k] = (Fib(k - 2) + Fib(k - 1)) % q) : dp[k] % q;
}
