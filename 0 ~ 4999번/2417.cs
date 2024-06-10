long a = long.Parse(Console.ReadLine());
Console.Write(BS(a));

long BS(long n)
{
    long result = 0, s = 0, e = n, m;

    while (s <= e)
    {
        m = (s + e) / 2;
        if (n <= Math.Pow(m, 2))
        {
            result = m;
            e = m - 1;
        }
        else s = m + 1;
    }

    return result;
}