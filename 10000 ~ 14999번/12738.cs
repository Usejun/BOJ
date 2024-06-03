using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var a = rd.ReadLine().Split().Select(int.Parse).ToArray();
var l = new List<int>() { a[0] };

for (int i = 1; i < n; i++)
{
    if (a[i] > l[^1]) l.Add(a[i]);
    else Add(a[i]);
}

wt.Write(l.Count);

void Add(int k)
{
    int a = 0, b = l.Count - 1, m;
    while (a < b)
    {
        m = a + (b - a) / 2;
        if (l[m] >= k) b = m;
        else a = m + 1;
    }

    l[b] = k;
}