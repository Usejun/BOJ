var map = new string[5][];
var s = new HashSet<int>();
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1) };
for (int i = 0; i < 5; i++)
    map[i] = Console.ReadLine().Split();

for (int i = 0; i < 5; i++)
    for (int j = 0; j < 5; j++)
        DFS(i, j, 1, map[i][j]);

Console.Write(s.Count);

void DFS(int x, int y, int depth, string str)
{
    if (depth == 6)
    {
        s.Add(int.Parse(str));
        return;
    }

    for (int i = 0; i < 4; i++)
    {
        int dx = x + d[i].x, dy = y + d[i].y;

        if (dx < 0 || dy < 0 || dx > 4 || dy > 4) 
            continue;
      
        DFS(dx, dy, depth + 1, str + map[dx][dy]);
    }
}