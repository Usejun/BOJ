using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
double x = input[0], y = input[1], z = 31250;

wt.Write((x, y) switch
{
    (0, 0) => $"{125:0.00} {125:0.00}",
    (125, 125) => $"{0:0.00} {0:0.00}",
    (0, < 125) => $"{Math.Round(z / (250 - y), 2):0.00} {Math.Round(250 - z / (250 - y), 2):0.00}",
    (0, >= 125) => $"{Math.Round(z / y, 2):0.00} {0:0.00}",
    (< 125, 0) => $"{Math.Round(250 - z / (250 - x), 2):0.00} {Math.Round(z / (250 - x), 2):0.00}",
    (>= 125, 0) => $"{0:0.00} {Math.Round(z / x, 2):0.00}",
    (< 125, > 125) => $"{Math.Round(250 - z / y, 2):0.00} {0:0.00}",
    (> 125, < 125) => $"{0:0.00} {Math.Round(250 - z / x, 2):0.00}",
    _ => $"",
});
