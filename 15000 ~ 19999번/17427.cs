int n = int.Parse(Console.ReadLine());
Console.Write(Enumerable.Range(1, n).Select(i => (long)(n / i) * i).Sum());