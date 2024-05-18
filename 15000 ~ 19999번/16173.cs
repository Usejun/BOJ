using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var v = new bool[n, n];
var map = new int[n][];

for (int i = 0; i < n; i++)
    map[i] = rd.ReadLine().Split().Select(int.Parse).ToArray();

Go(0, 0);

wt.Write("Hing");

void Go(int x, int y)
{
    v[x, y] = true;

    if (map[x][y] == -1)
    {
        wt.Write("HaruHaru");
        wt.Close();
        Environment.Exit(0);
    }

    if (x + map[x][y] < n && !v[x + map[x][y], y]) Go(x + map[x][y], y);
    if (y + map[x][y] < n && !v[x, y + map[x][y]]) Go(x, y + map[x][y]);
}