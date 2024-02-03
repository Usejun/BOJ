using StreamWriter sw = new(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var dp = new bool[n, n];

for (int i = 0; i < n; i++)
{
    dp[i, i] = true;
    if (i < n - 1) dp[i, i + 1] = a[i] == a[i + 1];
}

for (int i = n - 3; i >= 0; i--)
    for (int j = n - 1; j > i + 1; j--)
        if (a[i] == a[j] && dp[i + 1, j - 1])
            dp[i, j] = true;

n = int.Parse(Console.ReadLine());

while (n-- > 0)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    sw.WriteLine(dp[input[0] - 1, input[1] - 1] ? "1" : "0");
}