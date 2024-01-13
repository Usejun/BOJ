using StreamWriter sw = new(Console.OpenStandardOutput());
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
var d = new Dictionary<string, int>();
int n = input[0], m = input[1];
var l = new List<string>();

for (int i = 0; i < n; i++)
{
    var s = Console.ReadLine();
    if (s.Length < m) continue;
    d.TryAdd(s, 0);
    d[s]++;
    l.Add(s);
}

l.Sort(string.Compare);
var t = l.Distinct().OrderByDescending(i => d[i]).ThenByDescending(i => i.Length).ToArray();

foreach (var i in t)
    sw.WriteLine(i);
