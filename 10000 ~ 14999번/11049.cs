int n = int.Parse(Console.ReadLine());
var a = new (int r, int c)[501];
var dp = new int[501, 501];

for (int i = 1; i <= n; i++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    a[i] = (input[0], input[1]);
}

for (int i = 1; i < n; i++)
    for (int j = 1; i + j <= n; j++)
        for (int k = j; k < i + j; k++)
            dp[j, i + j] = Math.Min(dp[j, i + j] == 0 ? 987654321 : dp[j, i + j], dp[j, k] + dp[k + 1, i + j] + a[j].r * a[k].c * a[i + j].c);

Console.Write(dp[1, n]);