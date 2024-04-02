using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
long sum = 0;
var part = new List<long>();

for (int i = 0; i < n; i++)
    part.Add(rd.ReadLine().Split().Skip(1).Select(long.Parse).Sum());

part.Sort();
sum += part.Sum() * n;

for (int i = 0; i < n; i++)
    sum -= part[i] * i;

wt.WriteLine(sum);