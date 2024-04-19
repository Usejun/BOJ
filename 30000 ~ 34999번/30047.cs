using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var str = rd.ReadLine();
var s = new Stack<int>();
bool flag = true;

for (int i = str.Length - 1; flag && i >= 0; i--)
{
    if (str[i] == 'x') s.Push(0);
    else if (str[i] == 'g')
    {
        if (s.TryPop(out var v))
            s.Push(v + 1);
        else flag = false;
    }
    else
    {
        if (s.TryPop(out var v1) && s.TryPop(out var v2))
            s.Push(Math.Min(v1, v2));
        else flag = false;
    }
}

wt.Write(flag && s.Count == 1 ? s.Pop() : -1);