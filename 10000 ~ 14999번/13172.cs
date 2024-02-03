int m = int.Parse(Console.ReadLine());
long N = 1, S = 0, M = 1000000007;

while (m-- > 0)
{
    var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
    long n = input[0], s = input[1];
    S = (s * N + S * n) % M;
    N = (N * n) % M;
}

Console.Write(S % N == 0 ? S / N : S * Pow(N, M - 2) % M);

long Pow(long k, long c)
{
    if (c == 1) return k;
    if (c % 2 == 1) return k * Pow(k, c - 1) % M;
    long p = Pow(k, c / 2);
    return p * p % M;
}