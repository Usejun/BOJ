int n = int.Parse(Console.ReadLine()), k = int.Parse(Console.ReadLine()), c = 0;

for (int i = 1; i <= n; i++)
    if (Able(i)) c++;

Console.Write(c);

bool Able(int a)
{
    int b = 2;
    while (b <= k)
    {
        while (a % b == 0) a /= b;
        ++b;
    }

    return a == 1;
}