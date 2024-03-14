using StreamWriter w = new(Console.OpenStandardOutput());
int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
    long c = 0, p = 0, max = -1;

    for (int i = n - 1; i >= 0; i--)
    {
        max = Math.Max(max, a[i]);

        if (a[i] < max)
            p += max - a[i];        
    }

    w.WriteLine(p);
}