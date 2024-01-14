try
{
	while (true)
	{
		int n = int.Parse(Console.ReadLine());
		long k = 1;
		long c = 1;
		while (true)
		{
			k %= n;
			if (k == 0) break;
			k = (k * 10) % n + 1 % n;
			c++;
		}
        Console.WriteLine(c);
    }
}
catch { }
