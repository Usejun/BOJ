using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
Console.Write(Math.Min(n / 2, m));