using StreamWriter sw = new(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine());

Find(2, 1);
Find(3, 1);
Find(5, 1);
Find(7, 1);

void Find(int prime, int depth)
{
    if (depth == n)
    {
       sw.WriteLine(prime);
        return;
    }

    for (int i = 0; i < 10; i++)    
        if (isPrime(prime * 10 + i))
            Find(prime * 10 + i, depth + 1);    
}

bool isPrime(int prime)
{
    int sprt = (int)Math.Sqrt(prime);

    for (int i = 2; i <= sprt; i++)
        if (prime % i == 0)
            return false;
    return true;    
}