int n = int.Parse(Console.ReadLine()), m = 0, k = 0;
List<(int x, int y)> a = new();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    a.Add((input[0], input[1]));
}

a.Sort((i, j) => i.x.CompareTo(j.x));

for (int i = 0; i < n; i++)
{
    if (a[i].x > m)
    {
        k += a[i].x - m;
        m = a[i].x;
    }

    k += a[i].y;
    m += a[i].y;
}

Console.Write(k);