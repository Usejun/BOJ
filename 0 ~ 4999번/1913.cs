using StreamWriter sw = new(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());

(int x, int y)[] d = { (-1, 0), (0, 1), (1, 0), (0, -1) };
var map = new int[n, n];

(int x, int y) = (n / 2, n / 2);
int number = 1;
int depth = 1;
int dir = 0;
int count = 0;

map[x, y] = number++;

while (true)
{
    if (x < 0 || x >= n || y < 0 || y >= n || number >= n * n) break;

    for (int i = 0; i < depth; i++)
	{
		x += d[dir].x;
		y += d[dir].y;

		if (x < 0 || x >= n || y < 0 || y >= n || number >= n * n) break;

		map[x, y] = number++;
	}
	dir = (dir + 1) % 4;
	count++;
	if (count == 2)
	{
		depth++;
		count = 0;
	}
}

map[0, 0] = n * n;

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		if (map[i, j] == k)
			(x, y) = (i + 1, j + 1);
		sw.Write(map[i, j] + " ");
    }
    sw.WriteLine();
}
sw.WriteLine(x + " " + y);