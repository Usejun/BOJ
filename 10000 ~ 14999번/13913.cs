var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], MAX = 200001;
var q = new Queue<(int p, int c)>();
var v = new bool[MAX];
var a = new int[MAX];
var l = new List<int>();

q.Enqueue((n, 0));
v[n] = true;
a[n] = -1;

while (q.TryDequeue(out var k))
{
    if (k.p == m)
    {
        for (int i = m; i != -1; i = a[i]) l.Add(i);        
        Console.WriteLine(l.Count-1);
        Console.WriteLine(string.Join(" ", l.Reverse<int>()));
        break;
    }
  
    if (k.p - 1 >= 0 && !v[k.p - 1])
    {
        v[k.p - 1] = true;
        a[k.p - 1] = k.p;
        q.Enqueue((k.p - 1, k.c + 1));
    }
    if (k.p + 1 < MAX && !v[k.p + 1])
    {
        v[k.p + 1] = true;
        a[k.p + 1] = k.p;
        q.Enqueue((k.p + 1, k.c + 1));
    }
    if (2 * k.p < MAX && !v[2 * k.p])
    {
        v[2 * k.p] = true;
        a[2 * k.p] = k.p;
        q.Enqueue((2 * k.p, k.c + 1));
    }
}