using StreamWriter sw = new(Console.OpenStandardOutput());
int t = int.Parse(Console.ReadLine()), w, h, count, dx, dy;
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };
Queue<(char c, int x, int y, int k)> q1 = new(), q2 = new();

while (t-- > 0)
{
    q1.Clear();
    q2.Clear();
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    w = input[0];
    h = input[1];
    count = int.MaxValue;
    var map = Enumerable.Range(0, h).Select(i => Console.ReadLine()).ToArray();
    var v = new bool[2, h, w];

    for (int i = 0; i < h; i++)
        for (int j = 0; j < w; j++)
            if (map[i][j] == '*')
            {
                q1.Enqueue(('*', i, j, 1));
                v[0, i, j] = true;     
            }
            else if (map[i][j] == '@')
            {
                q2.Enqueue(('@', i, j, 1));
                v[1, i, j] = true;
            }

    while (q2.Count > 0)
        q1.Enqueue(q2.Dequeue());

    while (q1.Count > 0)
    {
        var k = q1.Dequeue();

        for (int i = 0; i < 4; i++)
        {
            dx = k.x + d[i].x;
            dy = k.y + d[i].y;

            if (dx < 0 || dx >= h || dy < 0 || dy >= w)
            {
                if (k.c == '@')
                {
                    count = Math.Min(count, k.k);
                    break;
                }
                continue;
            }

            if (map[dx][dy] != '#')
                if (k.c == '@' && !v[1, dx, dy] && !v[0, dx, dy])
                {
                    v[1, dx, dy] = true;
                    q1.Enqueue((k.c, dx, dy, k.k + 1));                
                }
                else if (k.c == '*' && !v[0, dx, dy])
                {
                    v[0, dx, dy] = true;
                    q1.Enqueue((k.c, dx, dy, 1));
                }
        }
    }
    sw.WriteLine(count == int.MaxValue ? "IMPOSSIBLE" : count);
}