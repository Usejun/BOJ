using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var rl = () => rd.ReadLine().Split().Select(int.Parse).ToArray();
var input = rl();
int n = input[0], k = input[1];
var s = rl();
var d = rl();

for (int i = 0; i < k; i++)
{
    var t = new int[n];
    for (int j = 0; j < n; j++)
        t[d[j] - 1] = s[j];
    s = t;
}

wt.WriteLine(string.Join(" ", s));
