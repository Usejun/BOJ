using Read r = new();
using Write w = new();

int n = r.Int(), M = 1000009;
var a = r.Int(n);
var b = new bool[M];
var c = new int[M];

for (int i = 0; i < n; i++) b[a[i]] = true;

for (int i = 0; i < n; i++)
    for (int j = a[i] * 2; j < M; j += a[i])
        if (b[j])
            (c[a[i]], c[j]) = (c[a[i]] + 1, c[j] - 1);

w.Enu(a.Select(i => c[i]), e:"");

class Read : IDisposable
{
    StreamReader r = new(new BufferedStream(Console.OpenStandardInput(), 1 << 16));

    public string Str() => r.ReadLine();

    public int Int()
    {
        var (n, i, c) = (false, 0, 32);

        while (Whi(c)) c = r.Read();

        (n, i) = (c == '-', i * 10 + (c - '0'));

        while (true)
        {
            c = r.Read();

            if (Whi(c)) break;

            i = i * 10 + (c - '0');                            
        }        

        return n ? -i : i;
    }

    public int[] Int(int l)
    {
        var a = new int[l];

        for (int i = 0; i < l; i++)
            a[i] = Int();

        return a;
    }

    public long Lon()
    {
        var (n, l, c) = (false, 0L, 32);

        while (Whi(c)) c = r.Read();

        (n, l) = (c == '-', l * 10 + (c - '0'));

        while (true)
        {
            c = r.Read();

            if (Whi(c)) break;

            l = l * 10 + (c - '0');
        }

        return n ? -l : l;
    }

    public long[] Lon(int l)
    {
        var a = new long[l];

        for (int i = 0; i < l; i++)
            a[i] = Lon();

        return a;
    }

    bool Whi(int c) => c == ' ' || c == '\t' || c == '\n' || c == '\r';

    public void Dispose() => r.Close();

}

class Write : IDisposable
{
    StreamWriter w = new(new BufferedStream(Console.OpenStandardOutput(), 1 << 16));

    public void Str(string s, string e = "\n") { w.Write(s); w.Write(e); }
    
    public void Obj(object o, string e = "\n") => Str(o?.ToString() ?? "", e);
    
    public void Enu<T>(IEnumerable<T> ea, string s = " ", string e = "\n")
    {
        foreach (var el in ea) Obj(el, s);
        Str("", e);
    }

    public void Dispose() => w.Close();
}