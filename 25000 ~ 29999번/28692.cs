using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
decimal sx = 0, sy = 0, sxx = 0, sxy = 0, a, b;

for (int i = 0; i < n; i++)
{
    var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
    int x = input[0], y = input[1];

    sx += x;
    sy += y;
    sxx += x * x;
    sxy += x * y;
}

a = sx * sx == n * sxx ? 0 : (n * sxy - sx * sy) / (n * sxx - sx * sx);
b = (sy - a * sx) / n;

wt.Write(sx * sx == n * sxx ? "EZPZ" : $"{a} {b}");