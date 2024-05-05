using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var a = new int[n];
var dp = new long[n];

for (int i = 0; i < n; i++)
    dp[i] = a[i] = int.Parse(rd.ReadLine());

for (int i = 1; i < n; i++)
    for (int j = i - 1; j >= 0; j--)
        if (a[i] > a[j])
            dp[i] = Math.Max(dp[i], dp[j] + a[i]);

wt.Write(dp.Max());