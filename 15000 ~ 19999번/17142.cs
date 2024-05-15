using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };
var q = new Queue<(int x, int y)>();
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], min = int.MaxValue;
var use = new int[m];
var map = new int[n][];
var virus = new List<(int x, int y)>();

for (int i = 0; i < n; i++)
{
    map[i] = rd.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < n; j++)
        if (map[i][j] == 2) virus.Add((i, j));    
}

for (int i = 0; i <= virus.Count - m; i++)
    Virus(i, 0);

wt.Write(min == int.MaxValue ? -1 : min);

void Virus(int w, int depth)
{
    if (depth == m)
    {
        min = Math.Min(min, Calc());
        return;
    }

    for (int i = w; i < virus.Count; i++)
    {
        use[depth] = i;
        Virus(i + 1, depth + 1);
    }
}

int Calc()
{
    q.Clear();
    var time = new int[n, n];
    var v = new bool[n, n];

    for (int i = 0; i < m; i++)
    {
        (int x, int y) = virus[use[i]];

        v[x, y] = true;
        q.Enqueue((x, y));    
    }

    while (q.TryDequeue(out var p))
    {
        (int x, int y) = p;

        for (int i = 0; i < 4; i++)
        {
            int dx = x + d[i].x;
            int dy = y + d[i].y;

            if (dx < 0 || dy < 0 || dx >= n || dy >= n || !(map[dx][dy] == 0 || map[dx][dy] == 2) || v[dx, dy])
                continue;

            v[dx, dy] = true;
            time[dx, dy] = time[x, y] + 1;
            q.Enqueue((dx, dy));
        }
    }

    int max = 0;

    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
        {
            if (time[i, j] == 0 && map[i][j] == 0)
            {
                max = int.MaxValue;
                break;
            }
            else if (max < time[i, j] && map[i][j] == 0)
                max = time[i, j];
        }

    return max;
}