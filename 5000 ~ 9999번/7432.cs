using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(Console.ReadLine());
var top = new Dictionary<string, Dir>();

for (int i = 0; i < n; i++)
{
    var paths = rd.ReadLine().Split('\\');

    if (!top.TryGetValue(paths[0], out var dir))
    {
        dir = new(paths[0], new());
        top.Add(paths[0], dir);
    }

    for (int j = 1; j < paths.Length; j++)
    {
        if (!dir.children.TryGetValue(paths[j], out var child))
        {
            Dir sub = new(paths[j], new());
            dir.children.Add(paths[j], sub);
            dir = sub;
        }
        else
            dir = child;
    }
}

Write(top, 0);

void Write(Dictionary<string, Dir> main, int depth)
{
    foreach ((var name, var dir) in main.OrderBy(i => i.Key))
    {
        wt.WriteLine(new string(' ', depth) + name);
        if (dir.children.Count != 0)
            Write(dir.children, depth + 1);
    }
}

record Dir(string name, Dictionary<string, Dir> children);
