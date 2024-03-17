var dp = new int[41];
(dp[0], dp[1], dp[2], dp[3]) = (1, 1, 2, 3);
for (int i = 4; i < 41; i++)
    dp[i] = dp[i - 1] + dp[i - 2];
int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine()), k = 0, c = 1;
for (int i = 0; i < m; i++)
{
    int w = int.Parse(Console.ReadLine());  
    c *= dp[w - k - 1];
    k = w;
}
c *= dp[n - k];
Console.Write(c);