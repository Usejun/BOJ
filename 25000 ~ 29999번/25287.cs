using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var t = int.Parse(rd.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(rd.ReadLine());
    var a = rd.ReadLine().Split().Select(int.Parse).ToArray();
    int v = a[0] = Math.Min(a[0], n - a[0] + 1), i;

    for (i = 0; i < n; i++)
    {
        int max = Math.Max(a[i], n - a[i] + 1);
        int min = Math.Min(a[i], n - a[i] + 1);

        if (v <= min) v = min;
        else if (v > min && v <= max) v = max;
        else break;

    }

    wt.WriteLine(i == n ? "YES" : "NO");
}