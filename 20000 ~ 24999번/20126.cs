var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], s = input[2], t = 0;
var l = new List<(int x, int y)>();

for (int i = 0; i < n; i++)
{
    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    l.Add((input[0], input[1]));
}

l = l.OrderBy(i => i.x).ToList();

foreach ((int x, int y) in l)
{
    if (t + m <= x)         
        break;        
    t = x + y;        
}

if (l[^1].x + l[^1].y == t)
    t = t + m <= s ? t : -1;
Console.Write(t);