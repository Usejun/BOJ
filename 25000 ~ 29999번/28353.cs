using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], w = input[1], l = 0, r = n - 1, c = 0;
var a = rd.ReadLine().Split().Select(int.Parse).OrderBy(i => i).ToArray();

while (l < r)
{
    if (a[l] + a[r] <= w)
        (l, r, c) = (l + 1, r - 1, c + 1);
    else r--;        
}

wt.Write(c);