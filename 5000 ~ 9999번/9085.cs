using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var t = int.Parse(rd.ReadLine());
while (t-- > 0)
{
    rd.ReadLine();
    wt.WriteLine(rd.ReadLine().Split().Select(int.Parse).Sum());
}