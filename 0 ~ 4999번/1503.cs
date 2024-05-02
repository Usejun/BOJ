using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], c = 1001, a = int.MaxValue;
HashSet<int> s = new HashSet<int>();
if (m != 0) s = new HashSet<int>(rd.ReadLine().Split().Select(int.Parse));
else rd.ReadLine();

for (int i = 1; i < c; i++)
{
    if (s.Contains(i)) continue;
	for (int j = 1; j < c; j++)
	{
        if (s.Contains(j)) continue;
		for (int k = 1; k <= c; k++)
		{
			if (s.Contains(k)) continue;
			int b = i * j * k;
            a = Math.Min(a, Math.Abs(n - b));
			if (n < b) break;
		}
    }
}

wt.Write(a);