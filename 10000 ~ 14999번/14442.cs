var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], k = input[2], count = int.MaxValue;
var map = Enumerable.Range(0, n).Select(i => Console.ReadLine()).ToArray();
var v = new bool[k + 1, n, m];
var q = new Queue<(int x, int y, int w, int c)>();
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };

q.Enqueue((0, 0, 0, 0));
v[0, 0, 0] = true;

while (q.Count > 0)
{
    var a = q.Dequeue();

	if (a.x == n - 1 && a.y == m - 1)
	{
		count = a.c + 1;
		break;
	}

	for (int i = 0; i < 4; i++)
	{
		int dx = a.x + d[i].x;
		int dy = a.y + d[i].y;

		if (dx < 0 || dx >= n || dy < 0 || dy >= m) continue;

		if (map[dx][dy] == '1')
		{
			if (a.w < k && !v[a.w + 1, dx, dy])
			{
				v[a.w + 1, dx, dy] = true;
				q.Enqueue((dx, dy, a.w + 1, a.c + 1));				
			}
		}
		else if (!v[a.w, dx, dy])
		{
			v[a.w, dx, dy] = true;
			q.Enqueue((dx, dy, a.w, a.c + 1));
		}
	}
}

Console.Write(count == int.MaxValue ? -1 : count);