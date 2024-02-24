var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int r = input[0], c = input[1], count = int.MaxValue;
var map = Enumerable.Range(0, r).Select(i => Console.ReadLine()).ToArray();
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };
var q1 = new Queue<(char c, int x, int y, int k)>();
var q2 = new Queue<(char c, int x, int y, int k)>();
var v = new bool[2, r, c];

for (int i = 0; i < r; i++)
    for (int j = 0; j < c; j++)
        if (map[i][j] == 'J')
        {
            v[0, i, j] = true;
            q2.Enqueue(('J', i, j, 1));
        }
        else if (map[i][j] == 'F')
        {
            v[1, i, j] = true;
            q1.Enqueue(('F', i, j, 0));
        }

while (q2.Count != 0)
    q1.Enqueue(q2.Dequeue());

while (q1.Count != 0)
{
    var k = q1.Dequeue();

    for (int i = 0; i < 4; i++)
    {
        int dx = k.x + d[i].x;
        int dy = k.y + d[i].y;

        if (dx < 0 || dx >= r || dy < 0 || dy >= c)
        {
            if (k.c == 'J')
                count = Math.Min(count, k.k);
            continue;
        }

        if (map[dx][dy] != '#')
        {
            if (k.c == 'J' && !v[0, dx, dy] && !v[1, dx, dy])
            {
                v[0, dx, dy] = true;
                q1.Enqueue((k.c, dx, dy, k.k + 1));
            }
            else if (k.c == 'F' && !v[1, dx, dy])
            {
                v[1, dx, dy] = true;
                q1.Enqueue((k.c, dx, dy, 0));
            }

        }
    }
}

Console.Write(count == int.MaxValue ? "IMPOSSIBLE" : count);