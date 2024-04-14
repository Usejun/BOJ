using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(long.Parse).ToArray();
long n = input[0], k = input[1];
var a = rd.ReadLine().Split().Select(long.Parse).OrderByDescending(i => i).ToArray();
long l = 0, r = a[0], answer = 0;

while (l <= r)
{
    long mid = (l + r) / 2;
    if (Able(mid))
    {
        answer = mid;
        r = mid - 1;
    }
    else
        l = mid + 1;
}   

wt.Write(answer);

bool Able(long w)
{
    long sum = 0;
    foreach (var i in a)
    {
        if (i < w) break;
        sum += i - w;
    }
    return sum <= k;
}