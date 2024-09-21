using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine()), k = 1;
var a = rd.ReadLine().Split().Select(int.Parse).OrderBy(i => i).ToArray();

foreach (var i in a)
{
    if (k < i) break;
    k += i;
}

wt.Write(k);
