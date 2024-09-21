int n = int.Parse(Console.ReadLine()), f1 = 0;

for (int i = 0; i < n; i++)
{
	var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	int c = input[0], k = input[1];
	if (k != 0) f1 += c * k;
}

Console.Write(f1);
