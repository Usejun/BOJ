while (true)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int n = input[0], m = input[1], k = input[2], c = int.MaxValue;
    if (n == 0 && m == 0 && k == 0) break;
    var map = new char[n, m, k];
    var v = new bool[n, m, k];
    var q = new Queue<(int x, int y, int z, int c)>();
    var d = new (int x, int y, int z)[] { (0, 1, 0), (1, 0, 0), (-1, 0, 0), (0, -1, 0), (0, 0, 1), (0, 0, -1) };
    (int x, int y, int z) e = (0, 0, 0);
    (int x, int y, int z, int) s = (0, 0, 0, 0);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            var str = Console.ReadLine();
            for (int w = 0; w < k; w++)
            {
                if (str[w] == 'E') e = (i, j, w);
                else if (str[w] == 'S') s = (i, j, w, 0);
                map[i, j, w] = str[w];
            }
        }
        Console.ReadLine();
    }

    q.Enqueue(s);
    v[s.x, s.y, s.z] = true;

    while (q.TryDequeue(out var r))
    {
        if (e.x == r.x && e.y == r.y && e.z == r.z)
        {
            c = r.c;
            break;
        }

        for (int i = 0; i < 6; i++)
        {
            int dx = r.x + d[i].x;
            int dy = r.y + d[i].y;
            int dz = r.z + d[i].z;

            if (dx < 0 || dy < 0 || dz < 0 || dx >= n || dy >= m || dz >= k || map[dx, dy, dz] == '#' || v[dx, dy, dz]) continue;

            q.Enqueue((dx, dy, dz, r.c + 1));
            v[dx, dy, dz] = true;
        }
    }
    Console.WriteLine(c == int.MaxValue ? "Trapped!" : $"Escaped in {c} minute(s)." );
}