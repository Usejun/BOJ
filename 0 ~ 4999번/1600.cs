int k = int.Parse(Console.ReadLine());
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int w = input[0], h = input[1];
var map = Enumerable.Range(0, h).Select(i => Console.ReadLine().Split().Select(int.Parse).ToArray()).ToArray();
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1), (-2, -1), (-1, -2), (1, -2), (-2, 1), (2, -1), (-1, 2), (1, 2), (2, 1) };
var q = new Queue<(int x, int y, int c, int k)>();
var v = new bool[h, w, k+1];

q.Enqueue((0, 0, 0, 0));
v[0, 0, 0] = true;

while (q.Count > 0)
{
    var n = q.Dequeue();

    if (n.x == h - 1 && n.y == w - 1)
    {
        Console.Write(n.c);
        return;
    }

    for (int i = 0; i < d.Length; i++)
    {
        var dx = n.x + d[i].x;
        var dy = n.y + d[i].y;

        if (dx < 0 || dx >= h || dy < 0 || dy >= w || map[dx][dy] == 1) continue;

        if (i < 4)
        { 
            if (!v[dx, dy, n.k])
            {
                v[dx, dy, n.k] = true;        
                q.Enqueue((dx, dy, n.c + 1, n.k));
            }
        }
        else
        {
            if (n.k >= k) break;
            if (!v[dx, dy, n.k + 1])
            {
                v[dx, dy, n.k + 1] = true;
                q.Enqueue((dx, dy, n.c + 1, n.k + 1));
            }
        }
    }
}
Console.Write(-1);
