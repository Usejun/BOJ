using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var a = new Dictionary<string, string>();
var v = new HashSet<string>();
int count = 0, time = 1;

while (true)
{
    count = 0;
    a.Clear();
    v.Clear();

    int n = int.Parse(rd.ReadLine());

    if (n == 0) break;

    for (int i = 0; i < n; i++)
    {
        var input = rd.ReadLine().Split();
        a.Add(input[0], input[1]);
    }

    foreach (var key in a.Keys)
        if (!v.Contains(key))
        {
            v.Add(key);
            if (DFS(key, a[key]))
                count++;
        }

    wt.WriteLine($"{time++} {count}");
}

bool DFS(string name, string friends)
{
    if (v.Contains(friends))
        return false;
    else
    {
        v.Add(friends);
        return a[friends] == name || DFS(name, a[friends]);
    }
}