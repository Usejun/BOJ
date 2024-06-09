int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int v = input[0], e = input[1];
    var vertex = new List<int>[v + 1];
    var set = new int[v + 1];
    bool flag = true;

    for (int i = 1; i <= v; i++)
        vertex[i] = new();

    for (int i = 0; i < e; i++)
    {
        input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int a = input[0], b = input[1];

        vertex[b].Add(a);
        vertex[a].Add(b);
    }

    for (int i = 1; i <= v; i++)
        if (set[i] == 0)
            DFS(i, 1);

    

    Console.WriteLine(flag ? "YES" : "NO");

    void DFS(int x, int n)
    {
        if (!flag) return;

        set[x] = n;

        foreach (var i in vertex[x])
            if (set[i] == 0)
                DFS(i, n == 1 ? -1 : 1);
            else if (set[i] == n)
                flag = false;
    }
}