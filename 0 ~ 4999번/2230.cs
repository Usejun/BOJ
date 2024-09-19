var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
var l = new List<int>();

for	(int i = 0; i < n; i++)
	l.Add(int.Parse(Console.ReadLine()));

l.Sort();

int a = 0, b = 0, c = 2000000000;

while (a < n && b < n)
{
	int k = l[b] - l[a];
	if (k >= m)
	{
		c = Math.Min(c, k);
		a++;
	}
	else b++;
}

Console.Write(c);
