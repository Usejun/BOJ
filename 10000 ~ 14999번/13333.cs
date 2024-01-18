int n = int.Parse(Console.ReadLine()), l = n;
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();

while (n > 0)
{
	int count = 0;
	for (int i = 0; i < l; i++)	
		if (a[i] >= n)
			count++;
	
	if (count >= n) break;
	n--;
}

Console.Write(n);
