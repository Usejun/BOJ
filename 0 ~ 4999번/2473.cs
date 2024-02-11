int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).OrderBy(i=>i).ToArray();
(int a, int b, int c, long sum) min = (0, 0, 0, long.MaxValue);

for (int i = 0; i < n - 2; i++)
{
    int l = i+1, r = n - 1;
    while (l < r)
	{
        long sum = 1L * a[i] + a[l] + a[r];

        if (Math.Abs(sum) < min.sum)
            min = (a[i], a[l], a[r], Math.Abs(sum));

        if (sum < 0) l++;
        else r--;        
	}
}

Console.WriteLine($"{min.a} {min.b} {min.c}");