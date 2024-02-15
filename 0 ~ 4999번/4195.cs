using StreamWriter w = new(Console.OpenStandardOutput());
using StreamReader r = new(Console.OpenStandardInput());
var u = new Dictionary<string, string>();
var n = new Dictionary<string, int>();
int t = int.Parse(r.ReadLine());

while (t-- > 0)
{
    int k = int.Parse(r.ReadLine());
    for (int i = 0; i < k; i++)
    {
        var f = r.ReadLine().Split();
        u.TryAdd(f[0], f[0]);
        n.TryAdd(f[0], 1);
        u.TryAdd(f[1], f[1]);
        n.TryAdd(f[1], 1);
        U(f[0], f[1]);
        w.WriteLine(n[F(f[0])]);
    }
    u.Clear();
    n.Clear();
}

void U(string a, string b)
{
    a = F(a);
    b = F(b);

    if (a != b)
    {
        u[b] = a;
        n[a] += n[b];
    }
}

string F(string s) => u[s] == s ? u[s] : u[s] = F(u[s]);