int t = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
int m = int.Parse(Console.ReadLine());
var b = Console.ReadLine().Split().Select(int.Parse).ToArray();;
var al = new List<int>();
var bd = new Dictionary<int, int>();
long c = 0;

for (int i = 0; i < n; i++)
{
    int k = 0;
	for (int j = i; j < n; j++)	
		al.Add((k += a[j]));
}

for (int i = 0; i < m; i++)
{
    int k = 0;
    for (int j = i; j < m; j++)
    {
        k += b[j];
        bd.TryAdd(k, 0);
        bd[k]++;
    }
}

al.Sort();

for (int i = 0; i < al.Count; i++)
    c = bd.ContainsKey(t - al[i]) ? c + bd[t - al[i]] : c;

Console.WriteLine(c);
