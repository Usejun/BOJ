using System.Numerics;

using StreamWriter w = new(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine());;
w.WriteLine(BigInteger.Pow(2, n) - 1);
if (n > 20) return;
Hanoi(n, 1, 2, 3);

void Hanoi(int N, int s, int m, int e)
{
    if (N == 1)
        w.WriteLine($"{s} {e}");
    else
    {
        Hanoi(N - 1, s, e, m);
        w.WriteLine($"{s} {e}");
        Hanoi(N - 1, m, s, e);
    }
}
