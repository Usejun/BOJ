using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(long.Parse).ToArray();
long n = input[0], t = input[1];
var l = new List<long>();
var ll = new List<(long, long)>(); 

for (int i = 0; i < n; i++)
{
    input = rd.ReadLine().Split().Select(long.Parse).ToArray();
    l.Add(input[0] + input[1] * t);
    ll.Add((input[0], input[1]));
}

var r = ll[0];
ll = ll.OrderBy(x => x.Item1).ToList();
int index = ll.IndexOf(r);
l.Sort();
wt.WriteLine(l[index]);