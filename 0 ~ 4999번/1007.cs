int n;
bool[] v = new bool[0];
(int x, int y)[] a;
double r;

int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
	n = int.Parse(Console.ReadLine());
	v = new bool[n];
	a = new (int x, int y)[n];
	r = double.MaxValue;
	
	for (int i = 0; i < n; i++)
	{
		var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
		a[i] = (input[0], input[1]);
	}
	
	Select(0, 0);
	Console.WriteLine($"{r:0.0000000}");
}

void Select(int k, int c)
{
	if (c == n/2)
	{
		r = Math.Min(r, Sum());
		return;
	}
	
	for (int i = k+1; i < n; i++)	
		if (!v[i])
		{
			v[i] = true;
			Select(i, c+1);
			v[i] = false;
		}
}

double Sum()
{
	double x = 0, y = 0;
	for (int i = 0; i < n; i++)
	{ 
		x = v[i] ? x - a[i].x : x + a[i].x;
		y = v[i] ? y - a[i].y : y + a[i].y;
	}

	return Math.Sqrt(x*x+y*y);
}
