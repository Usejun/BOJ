using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
int rest = 0, t = 600;
List<(int start, int end)> l = new();

for (int i = 0; i < n; i++)
{
    var time = rd.ReadLine().Split().Select(int.Parse).ToArray();
    l.Add((time[0] / 100 * 60 + time[0] % 100 - 10, time[1] / 100 * 60 + time[1] % 100 + 10));
}
l.Add((1320, int.MaxValue));

l = l.OrderBy(i => i.start).ToList();

for (int i = 0; i <= n; i++)
{
    rest = Math.Max(rest, l[i].start - t);
    t = Math.Max(t, l[i].end);           
}

wt.Write(rest);