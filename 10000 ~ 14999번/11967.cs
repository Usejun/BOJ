
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], c = 1;
var board = new List<(int x, int y)>[101, 101];

for (int i = 0; i < 101; i++)
    for (int j = 0; j < 101; j++)
        board[i, j] = new();
    
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };
var v = new bool[101, 101];
var l = new bool[101, 101];
var q = new Queue<(int x, int y)>();

for (int i = 0; i < m; i++)
{
    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    board[input[0], input[1]].Add((input[2], input[3]));
}

q.Enqueue((1, 1)); 
v[1, 1] = true;
l[1, 1] = true;

while (q.TryDequeue(out var p))
{
    foreach (var i in board[p.x, p.y])
    {
        if (l[i.x, i.y]) continue;

        l[i.x, i.y] = true;
        c++;
        for (int j = 0; j < 4; j++)
        {
            int dx = i.x + d[j].x, dy = i.y + d[j].y;
            if (dx < 1 || dy < 1 || dx > n || dy > n || !v[dx, dy])
                continue;
            v[i.x, i.y] = true;
            q.Enqueue(i);
            break;
        }
    }

    for (int i = 0; i < 4; i++)
    {
        int dx = p.x + d[i].x, dy = p.y + d[i].y;
        if (dx < 1 || dy < 1 || dx > n || dy > n || !l[dx, dy] || v[dx, dy])
            continue;

        v[dx, dy] = true;
        q.Enqueue((dx, dy));
    }
}

Console.Write(c);