var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sum = a.Take(m).Sum(), max = sum, count = 1;

for (int i = m; i < n; i++)
{
	sum += a[i] - a[i - m];
	if (max == sum)
		count++;
	else if (max < sum)
	{
		max = sum;
		count = 1;
	}
}

Console.Write(max == 0 ? "SAD" : $"{max}\n{count}");
