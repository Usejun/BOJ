int n = int.Parse(Console.ReadLine()), s = 0, b;

for (int i = 0; i < n; i++)
{
    int k = 0;
    while (true)
    {
        b = Console.Read();
        if (b == 32 || b == 10) break;
        k = k * 10 + (b-48);
    }
    s += k - i;
}

Console.Write(s);