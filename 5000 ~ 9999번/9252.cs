var n = Console.ReadLine();
var m = Console.ReadLine();
int N = n.Length, M = m.Length, i, j;
var a = new int[N+2, M+2];
var l = new List<char>();

for (i = 1; i <= N; i++)
    for (j = 1; j <= M; j++)
        a[i, j] = n[i - 1] == m[j - 1] ? a[i - 1, j - 1] + 1 : Math.Max(a[i, j - 1], a[i - 1, j]);
i = N;
j = M;

while (l.Count != a[N, M])
{
    if (a[i - 1, j] == a[i, j]) i--;
    else if (a[i, j - 1] == a[i, j]) j--;
    else
    {
        l.Add(n[i - 1]);
        i--; j--;
    }
}

Console.WriteLine(a[N, M]);
Console.Write(string.Join("", l.Reverse<char>()));