using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var d = new Dictionary<string, int>();

for (int i = 0; i < n; i++)
{
    var input = rd.ReadLine().Split();
    var time = input[0].Split(':').Select(int.Parse).ToArray();
    var name = input[1];

    d.TryAdd(name, 0);
    d[name] += time[0] * 60 + time[1];
}

foreach (var user in d.Keys)
{
    d[user] -= 100;
    if (d[user] > 0) d[user] = 10 + (d[user] / 50 + (d[user] % 50 == 0 ? 0 : 1)) * 3 ;         
    else d[user] = 10;
}

wt.WriteLine(string.Join('\n', d.OrderByDescending(i => i.Value).ThenBy(i => i.Key).Select(i => $"{i.Key} {i.Value}")));