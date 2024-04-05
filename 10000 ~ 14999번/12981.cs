using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int count = 0, a = 0, b = 0;
count = input.Sum(i => i / 3);
input = input.Select(i => i % 3).ToArray();
a = input.Count(i => i != 0);

while (input.Sum() != 0)
{
    if (input[0] > 0) input[0]--;
    if (input[1] > 0) input[1]--;
    if (input[2] > 0) input[2]--;
    b++;
}

wt.Write(count + Math.Min(a, b));