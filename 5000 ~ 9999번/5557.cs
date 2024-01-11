int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var dp = new long[21,n];

dp[a[0], 0] = 1;

for (int i = 1; i < n; i++)
{
    for (int j = 0; j < 21; j++)
    {
        int plus = j + a[i];
        int minus = j - a[i];

        if (plus <= 20)
            dp[plus, i] += dp[j, i - 1];
        if (minus >= 0)
            dp[minus, i] += dp[j, i - 1];
    }    
}

Console.WriteLine(dp[a[n - 1], n - 2]);
