using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], k = input[1];
var a = rd.ReadLine().Split().Select(int.Parse).ToArray();
var s = new long[n];
s[0] = a[0];

for (int i = 1; i < n; i++)
    s[i] = s[i - 1] + a[i];

Array.Sort(s);
Array.Reverse(s);

wt.Write(s.Take(k).Sum());