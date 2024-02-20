int n = int.Parse(Console.ReadLine()), count = 1, min = int.MaxValue;
var map = Enumerable.Range(0, n).Select(i => Console.ReadLine().Split().Select(int.Parse).ToArray()).ToArray();
var group = Enumerable.Range(0, n).Select(i => new int[n]).ToArray();
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };

for (int i = 0; i < n; i++)
	for (int j = 0; j < n; j++)
		if (map[i][j] == 1 && group[i][j] == 0)
			Grouping(i, j);

for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        if (map[i][j] == 1)
            Search(i, j, group[i][j]);

Console.Write(min);

void Grouping(int x, int y)
{
	var q = new Queue<(int x, int y)>();
	group[x][y] = count;
	q.Enqueue((x, y));

	while (q.Count > 0)
	{
		var k = q.Dequeue();
		for (int i = 0; i < 4; i++)
		{
			var dx = k.x + d[i].x;
			var dy = k.y + d[i].y;

			if (dx < 0 || dx >= n || dy < 0 || dy >= n || group[dx][dy] != 0 || map[dx][dy] == 0) continue;

			group[dx][dy] = count;
			q.Enqueue((dx, dy));
		}
	}

	count++;
}

void Search(int x, int y, int c)
{
	var q = new Queue<(int x, int y, int d)>();
	var v = new bool[n, n];
	v[x, y] = true;
	q.Enqueue((x, y, 0));

	while (q.Count > 0)
	{
		var k = q.Dequeue();

        for (int i = 0; i < 4; i++)
        {
            var dx = k.x + d[i].x;
            var dy = k.y + d[i].y;

            if (dx < 0 || dx >= n || dy < 0 || dy >= n || group[dx][dy] == c) continue;

			if (group[dx][dy] == 0 && !v[dx, dy] && k.d < min)
			{
				v[dx, dy] = true;
				q.Enqueue((dx, dy, k.d + 1));
			}
			else if (group[dx][dy] != 0)
				min = Math.Min(min, k.d);
        }
    }
}