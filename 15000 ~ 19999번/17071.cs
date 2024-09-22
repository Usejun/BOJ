var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int MAX = 500001, n = input[0], k = input[1];
var q = new Queue<(int x, int t)>();
var v = new bool[2, MAX];

q.Enqueue((n, 0));
v[0, n] = true;

while (q.Count != 0) 
{
	(int x, int c) = q.Dequeue();
	int pos = k + c * (c + 1) / 2;
	
	if (pos >= MAX) break;
	if (pos / 2 >= MAX) break; 
	if (v[c % 2, pos])
	{
		Console.Write(c);
		return;
	}

	c++;
	Add(x - 1, i => i >= 0);
	Add(x + 1, i => i < MAX);
	Add(2 * x, i => i < MAX);
	
	void Add(int p, Func<int, bool> con)
	{
		if (con(p) && !v[c % 2, p])
		{
			v[c % 2, p] = true;
			q.Enqueue((p, c));
		}
	}	
}

Console.Write(-1);
