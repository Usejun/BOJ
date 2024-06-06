int n = int.Parse(Console.ReadLine());
long count = 0;
List<int>[] l = new List<int>[4];
Dictionary<long, int> a = new();

for (int i = 0; i < 4; i++)
    l[i] = new();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < 4; j++)
        l[j].Add(input[j]);    
}

for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
    {
        long s = l[0][i] + l[1][j];
        a.TryAdd(s, 0);
        a[s]++;
    }

for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        if (a.TryGetValue(-l[2][i] - l[3][j], out var v))
            count += v;

Console.WriteLine(count);