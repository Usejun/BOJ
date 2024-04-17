using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine()), max = 0;
var a = rd.ReadLine().Split().Select(int.Parse).ToList();
Max(a, 0);
wt.Write(max);

void Max(List<int> l, int sum)
{
    if (l.Count == 2)
    {
        max = Math.Max(max, sum);
        return;
    }

    for (int i = 1; i < l.Count - 1; i++)
    {
        int v = l[i];
        l.RemoveAt(i);
        Max(l, sum + l[i - 1] * l[i]);
        l.Insert(i, v);
    }
}