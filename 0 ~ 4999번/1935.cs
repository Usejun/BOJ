int n = int.Parse(Console.ReadLine());
var ex = Console.ReadLine();
var c = new double[n];
var o = new Stack<double>();

for (int i = 0; i < n; i++)
    c[i] = double.Parse(Console.ReadLine());

foreach (var s in ex)
{
    if (s >= 'A') o.Push(c[s - 'A']);
    else
    {
        double a = o.Pop(), b = o.Pop();
        if (s == '+') o.Push(b + a);
        else if (s == '*') o.Push(b * a);
        else if (s == '-') o.Push(b - a);
        else if (s == '/') o.Push(b / a);
    }
}

Console.Write($"{o.Pop():.00}");