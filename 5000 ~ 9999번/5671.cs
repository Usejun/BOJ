int max = 5001;
var can = new bool[max];

for (int i = 0; i < max; ++i)
    can[i] = IsSolo($"{i}");

while (true)
{
    var s = Console.ReadLine();
    if (string.IsNullOrEmpty(s)) break;
    Console.WriteLine(Count(s.Split().Select(int.Parse)));
}

bool IsSolo(string k)
{
    for (int i = 0; i < 10; ++i)
        if (k.Count(j => j == '0' + i) > 1) return false;
    return true;
}

int Count(IEnumerable<int> t)
{
    int a = t.First(), b = t.Last(), c = 0;
    for (int i = a; i <= b; i++)        
        if (can[i]) c++;
    return c;
}