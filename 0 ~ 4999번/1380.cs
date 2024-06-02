using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int t = 0;
while (true)
{
    t++;
    int n = int.Parse(rd.ReadLine());

    if (n == 0) break;

    var name = new string[n];
    var have = new bool[n];

    for (int i = 0; i < n; i++)
        name[i] = rd.ReadLine();

    for (int i = 0; i < 2*n - 1; i++)
    {
        var str = rd.ReadLine().Split();
        var index = int.Parse(str[0]) - 1;
        have[index] = !have[index];
    }

    wt.Write(t);

    for (int i = 0; i < n; i++)
        if (have[i]) wt.Write($" {name[i]}");

    wt.WriteLine();
}