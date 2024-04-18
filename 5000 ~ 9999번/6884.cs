using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int t = int.Parse(rd.ReadLine());
while (t-- > 0)
{
    var a = rd.ReadLine().Split().Skip(1).Select(int.Parse).ToArray();
    int n = a.Length, i, j = 0;
    var sum = new int[n];
    bool found = false;
    sum[0] = a[0];

    for (i = 1; i < n; i++)
        sum[i] = sum[i - 1] + a[i];

    for (i = 2; !found && i <= n; i++)
    {
        found = IsPrime(sum[i - 1]);  
        for (j = i; !found && j < n; j++)
            found = IsPrime(sum[j] - sum[j - i]);
    }

    wt.WriteLine(found ? $"Shortest primed subsequence is length {i - 1}: {string.Join(" ", a.Skip(j - (i - 1)).Take(i - 1))}" : "This sequence is anti-primed.");
}

bool IsPrime(int k)
{
    for (int i = 2; i <= Math.Sqrt(k); i++)
        if (k % i == 0) return false;
    return true;
}