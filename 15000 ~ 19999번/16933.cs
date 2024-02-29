var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], k = input[2];
var map = Enumerable.Range(0, n).Select(i => Console.ReadLine()).ToArray();
var v = new bool[k+1, n, m];
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };
var q = new Queue<(int x, int y, int k, int c, bool s)>();

q.Enqueue((0, 0, 0, 0, true));
v[0, 0, 0] = true;

while (q.TryDequeue(out var p))
{
    if (p.x == n - 1 && p.y == m - 1)
    {
        Console.Write(p.c+1);
        return;
    }

    for (int i = 0; i < 4; i++)
    {
        int dx = p.x + d[i].x;
        int dy = p.y + d[i].y;

        if (dx < 0 || dy < 0 || dx >= n || dy >= m)
            continue;

        if (map[dx][dy] == '1' && p.k < k && !v[p.k + 1, dx, dy])
        {
            if (p.s)
            {
                v[p.k + 1, dx, dy] = true;
                q.Enqueue((dx, dy, p.k + 1, p.c + 1, false));
            }
            else q.Enqueue((p.x, p.y, p.k, p.c + 1, true));
        }
        else if (map[dx][dy] == '0' && !v[p.k, dx, dy])
        {
            v[p.k, dx, dy] = true;
            q.Enqueue((dx, dy, p.k, p.c + 1, !p.s));
        }
    }
}

Console.Write(-1);