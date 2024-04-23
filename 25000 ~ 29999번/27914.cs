using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], k = input[1], q = input[2], c = 0;
var a = rd.ReadLine().Split().Select(int.Parse).ToArray();
var qs = rd.ReadLine().Split().Select(int.Parse).ToArray();
var dp = new long[n + 1];

for (int i = 1; i <= n; i++)
{
    if (a[i - 1] != k) c++;
    else c = 0;
    dp[i] = dp[i - 1] + c;
}

foreach (var s in qs)
    wt.WriteLine(dp[s]);