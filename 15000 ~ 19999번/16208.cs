using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var a = rd.ReadLine().Split().Select(int.Parse).OrderBy(i => i).ToArray();
long sum = a.Sum(), result = 0;

foreach (var i in a)
    result += (sum -= i) * i;

wt.WriteLine(result);