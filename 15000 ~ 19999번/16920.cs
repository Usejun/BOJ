var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], k = input[2];
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };
var l = Console.ReadLine().Split().Select(int.Parse).ToArray();
var map = new string[n];
for (int i = 0; i < n; i++) 
    map[i] = Console.ReadLine();
var q = new Queue<(int x, int y)>[9]; 
for (int i = 0; i < 9; i++) 
    q[i] = new();
var v = new int[n, m];
var a = new int[k];

for (int i = 0; i < n; i++)
    for (int j = 0; j < m; j++)
        if (map[i][j] >= '1')
        {
            v[i, j] = map[i][j] - '0';
            q[map[i][j] - '1'].Enqueue((i, j));
        }
        else if (map[i][j] == '#') v[i, j] = -1;

while (q.Select(i => i.Count).Sum() != 0)
    for (int i = 0; i < k; i++)
        BFS(i);

for (int i = 0; i < n; i++)
    for (int j = 0; j < m; j++)
        if (v[i, j] > 0)
            a[v[i, j] - 1]++;

Console.Write(string.Join(" ", a));

void BFS(int k)
{
    var t = new Queue<(int x, int y)>();

    for (int i = 0; q[k].Count > 0 && i < l[k]; i++)
    {
        while (q[k].TryDequeue(out var p))
        {
            for (int j = 0; j < 4; j++)
            {
                int dx = p.x + d[j].x;
                int dy = p.y + d[j].y;

                if (dx < 0 || dy < 0 || dx >= n || dy >= m || v[dx, dy] != 0)
                    continue;

                v[dx, dy] = k + 1;
                t.Enqueue((dx, dy));
            }
        }
        while (t.TryDequeue(out var p))
            q[k].Enqueue(p);
    }
}