int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
    var dp = new int[n];
    dp[0] = a[0];

    for (int i = 1; i < n; i++)
        dp[i] = Math.Max(dp[i - 1] + a[i], a[i]);

    Console.WriteLine(dp.Max());

}