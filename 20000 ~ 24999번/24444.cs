var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], k = input[2], d = 1;
var v = new int[n + 1];
var e = new List<int>[n + 1];
var q = new Queue<int>();

for (int i = 1; i <= n; i++)
    e[i] = new();

for (int i = 0; i < m; i++)
{
    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    e[input[0]].Add(input[1]);
    e[input[1]].Add(input[0]);
}

for (int i = 1; i <= n; i++)
    e[i].Sort();

q.Enqueue(k);
v[k] = d++;

while (q.TryDequeue(out var w))
{
    foreach (var i in e[w])
        if (v[i] == 0)
        {
            v[i] = d++;
            q.Enqueue(i);
        }
}

Console.Write(string.Join('\n', v.Skip(1)));