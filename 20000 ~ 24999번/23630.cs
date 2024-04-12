using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var a = rd.ReadLine().Split().Select(int.Parse).ToArray();
var b = new int[33];

for (int i = 0; i < n; i++)
{
	int j = 0;
	while (a[i] > 0)
	{
		b[j] += a[i] % 2 == 1 ? 1 : 0;
		a[i] /= 2;
		j++;
	}
}

wt.WriteLine(b.Max());