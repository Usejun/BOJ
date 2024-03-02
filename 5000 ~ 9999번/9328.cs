using StreamWriter w = new(Console.OpenStandardOutput());
int t = int.Parse(Console.ReadLine());
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };
while (t-- > 0)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int n = input[0], m = input[1], c = 0;
    var map = new string[n];
    var v = new bool[n, m];
    var door = new Queue<(int x, int y)>();
    for (int i = 0; i < n; i++)
        map[i] = Console.ReadLine();

    var key = Console.ReadLine();
    var q = new Queue<(int x, int y)>();

    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            if ((i == 0 || j == 0 || i == n - 1 || j == m - 1))
            {
                if (map[i][j] == '*') continue;
                else if (map[i][j] >= 'a') key += map[i][j];
                else if (map[i][j] >= 'A' && map[i][j] <= 'Z')
                {
                    door.Enqueue((i, j));
                    if (!key.Contains((char)(map[i][j] + 32))) 
                        continue;
                }
                else if (map[i][j] == '$') c++;
                q.Enqueue((i, j));
                v[i, j] = true;                
            }                      

    while(q.Count > 0)
    {
        BFS();
        int l = door.Count;
        for (int i = 0; i < l; i++)
        {
            var k = door.Dequeue();
            if (key.Contains((char)(map[k.x][k.y] + 32)))
            {
                v[k.x, k.y] = true;
                q.Enqueue(k);
            }
            else door.Enqueue(k);                            
        }
    }

    void BFS()
    {
        while (q.TryDequeue(out var p))
        {
            for (int i = 0; i < 4; i++)
            {
                int dx = p.x + d[i].x;
                int dy = p.y + d[i].y;

                if (dx < 0 || dy < 0 || dx >= n || dy >= m || v[dx, dy] || map[dx][dy] == '*')
                    continue;

                if (map[dx][dy] >= 'a')
                    key += map[dx][dy];
                else if (map[dx][dy] == '$') c++;
                else if (map[dx][dy] >= 'A' && map[dx][dy] <= 'Z')
                {
                    door.Enqueue((dx, dy));
                    if (!key.Contains((char)(map[dx][dy] - 32)))
                        continue;
                }

                v[dx, dy] = true;
                q.Enqueue((dx, dy));
            }
        }
    }
    w.WriteLine(c);
}