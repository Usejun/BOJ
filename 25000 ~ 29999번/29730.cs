using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var l = new List<string>();
var b = new List<string>();

for (int i = 0; i < n; i++)
{
    var s = rd.ReadLine();
    if (s.StartsWith("boj.kr/") && int.TryParse(s.Substring(7, s.Length - 7), out var k))
        b.Add(s);
    else l.Add(s);        
}

wt.Write(l.Count != 0 ? string.Join("\n", l.OrderBy(s => s.Length).ThenBy(i => i)) + "\n" : "");
wt.Write(b.Count != 0 ? string.Join("\n", b.OrderBy(s => int.Parse(s.Substring(7, s.Length - 7)))) : "");