var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], k = input[2], d = 1;
var l = new List<int>[n+1];
var v = new int[n];

for (int i = 0; i < n + 1; i++)
    l[i] = new();

for (int i = 0; i < m; i++)
{
    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    l[input[0]].Add(input[1]);
    l[input[1]].Add(input[0]);
}

for (int i = 0; i < n + 1; i++)
    l[i].Sort();

DFS(k);
Console.Write(string.Join("\n", v));

void DFS(int w)
{
    v[w - 1] = d++;
    foreach (var i in l[w])    
        if (v[i - 1] == 0)
            DFS(i);
}