using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
List<(string n, int s, bool h)> l = new();

for (int i = 0; i < n; i++)
{
    var str = rd.ReadLine().Trim('[', '{', '}', ']', ',').Split(',');
    var name = str[0].Split(':')[1].Trim('"');
    var score = int.Parse(str[1].Split(":")[1]);
    var isHidden = int.Parse(str[2].Split(":")[1]) == 1;

    l.Add((name, score, isHidden));
}

l.Sort((x, y) => y.s.CompareTo(x.s) == 0 ? x.n.CompareTo(y.n) : y.s.CompareTo(x.s));

for (int i = 0; i < n; i++)
{
    if (l[i].h) continue;

    int t = 1;
    for (int j = 0; j < n; j++)
        if (l[i].s < l[j].s) t++;
    
    wt.WriteLine($"{t} {l[i].n} {l[i].s}");
}