using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
var a = new Dictionary<string, int>();

for (int i = 0; i < n; i++)
{
    var key = rd.ReadLine();
    if (!a.TryAdd(key, 0));
        a[key]++;
}

for (int i = 0; i < m; i++)
{
    int c = 0;
    var question = rd.ReadLine().Split();
    foreach (var key in a.Keys)
    {
        bool flag = true;
        foreach (var keyword in question)
            if (flag && keyword != "-")
                flag = key.Contains(keyword);
        if (flag) c += a[key]; 
    }
    wt.WriteLine(c);
}