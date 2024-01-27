int n = int.Parse(Console.ReadLine()), i = 0;
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var dp = Enumerable.Repeat(1, n).ToArray();
var route = Enumerable.Range(0, n).ToArray();

for (; i < n; i++)
	for (int j = i; j < n; j++)
		if (a[i] < a[j])
		{
			if (dp[j] < dp[i] + 1)
				route[j] = i;
			dp[j] = Math.Max(dp[j], dp[i] + 1);
		}

int max = dp.Max();
i = Array.IndexOf(dp, max);
var l = new List<int>() { };
while (true)
{
	l.Add(a[i]);
	if (i == route[i])	
		break;
	i = route[i];
}

l.Reverse();
Console.WriteLine(max);
Console.WriteLine(string.Join(" ", l));