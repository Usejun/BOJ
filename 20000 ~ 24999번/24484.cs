using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], r = input[2], depth = 1;
var l = new List<int>[200001];
var id = new long[200001, 2];
var v = new bool[200001];

for (int i = 0; i <= n; i++)
    l[i] = new();

for (int i = 0; i < m; i++)
{
    input = rd.ReadLine().Split().Select(int.Parse).ToArray();
    int a = input[0], b = input[1];
    l[a].Add(b);
    l[b].Add(a);
}

DFS(r, 0);

long sum = 0;

for (int i = 1; i <= n; i++)
    sum += id[i, 0] * id[i, 1];

wt.Write(sum);

void DFS(int s, int d)
{
    if (v[s]) return;

    id[s, 0] = depth++;
    id[s, 1] = d;
    v[s] = true;

    l[s].Sort();
    l[s].Reverse();

    foreach (var i in l[s])
        DFS(i, d + 1);    
}