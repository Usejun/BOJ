using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
wt.Write(2 * Math.Pow(3, int.Parse(Console.ReadLine()) - 1));