var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], a = 0, max = 0;
var l = new List<(int f, int t, int w)>();
var g = Enumerable.Range(0, n + 1).ToArray();

for (int i = 0; i < m; i++)
{
    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    l.Add((input[0], input[1], input[2]));
}

l = l.OrderBy(i => i.w).ToList();

for (int i = 0; i < m; i++)
{
    var (f, t, w) = l[i];
    if (Find(f) != Find(t))
    {
        Union(f, t);
        max = Math.Max(max, w);
        a += w;
    }
}

Console.Write(a - max);

int Find(int k)
{
    if (g[k] == k) return g[k];
    return g[k] = Find(g[k]);
}

void Union(int a, int b)
{
    a = Find(a);
    b = Find(b);
    if (a > b) g[a] = b;
    else g[b] = a;     
}