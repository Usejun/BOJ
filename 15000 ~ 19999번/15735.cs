using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var dp = new long[10001];
for (int i = 1; i <= n; i++)
    dp[i] = dp[i - 1] + i;
long sum = 0;

for (int i = 1; i <= n; i++)
    sum += dp[i];
for(int i = n - 1; i > 0; i-=2)
    sum += dp[i];

wt.Write(sum);