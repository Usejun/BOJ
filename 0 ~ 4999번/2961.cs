int n = int.Parse(Console.ReadLine()), min = int.MaxValue;
var l = new List<(int s, int b)>();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    l.Add((input[0], input[1]));
}

Min(0, 1, 0, 0);

Console.Write(min);

void Min(int i, int pow, int sum, int d)
{
    if (i == n)
    {
        if (d != 0)
            min = Math.Min(min, Math.Abs(sum - pow));
        return;
    }

    Min(i + 1, pow * l[i].s, sum + l[i].b, d + 1);
    Min(i + 1, pow, sum, d);
}