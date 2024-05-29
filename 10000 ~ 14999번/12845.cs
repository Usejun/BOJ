using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var a = rd.ReadLine().Split().Select(int.Parse);
wt.Write(a.Sum() + a.Max() * (n - 2));