using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
Dictionary<string, (int wrong, bool isPass)> k = new();
int n = int.Parse(rd.ReadLine());

for (int i = 0; i < n; i++)
{
    var submit = rd.ReadLine().Split();
    string name = submit[1];
    int state = int.Parse(submit[2]);
    if (name == "megalusion") continue;

    if (k.TryGetValue(name, out var info))
    {
        if (!info.isPass)
            k[name] = (info.wrong + (state == 4 ? 0 : 1), info.isPass || state == 4);
    }
    else k.Add(name, (state == 4 ? 0 : 1, state == 4));    
}

double person = 0;
double count = 0;

foreach ((_, (int wrong, bool isPass)) in k)
{
    if (!isPass) continue;

    person++;
    count += wrong;
}

wt.Write(person == 0 ? 0 : (person / (person + count)) * 100d);