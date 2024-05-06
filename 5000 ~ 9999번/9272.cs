using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], k = m - n + 1;
wt.Write(k * (k - 1) / 2);