using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
wt.Write(1 / (1 + Math.Pow(10, input[1] / 400d - input[0] / 400d)));