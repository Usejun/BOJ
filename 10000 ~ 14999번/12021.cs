using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(double.Parse).ToArray();
double a = input[0], b = input[1], c = Math.Sqrt(a * b);
wt.Write($"{a} {b}");