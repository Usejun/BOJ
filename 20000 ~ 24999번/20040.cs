using Read r = new();
using Write w = new();

int n = r.Int(), m = r.Int(), k = 0;
var u = new int[n + 1];

for (int i = 0; i < n; i++) u[i] = i;

for (int i = 0; i < m; i++)
{
    int a = r.Int(), b = r.Int();

    if (Find(a) == Find(b))
    {
        k = i + 1;
        break;
    }    

    Union(a, b);
}

w.Obj(k);

void Union(int a, int b)
{
    a = Find(a);
    b = Find(b);
    if (a > b) u[a] = b;
    else u[b] = a; 
}

int Find(int a)
{
    if (u[a] == a) return u[a];
    return u[a] = Find(u[a]);
}

class Read : IDisposable
{
    StreamReader r = new(new BufferedStream(Console.OpenStandardInput(), 1 << 16));

    public string Str() => r.ReadLine();

    public int Int()
    {
        bool n = false;
        int i = 0, c = ' ';

        while (Whi(c))
            c = r.Read();        

        n = c == '-';
        i = i * 10 + (c - '0');

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
        bool s = false, n = false;
        int l = 0;

        while (true)
        {
            int c = r.Read();

            if (Whi(c)) break;

            n = !s && c == '-';
            s = true;

            l = c != '-' ? l * 10 + (c - '0') : l;
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

    public void Dispose()
    {
        r.Close();
    }

}

class Write : IDisposable
{
    StreamWriter w = new(new BufferedStream(Console.OpenStandardOutput(), 1 << 16));

    public void Str(string s, string e = "\n") { w.Write(s); w.Write(e); }
    
    public void Obj(object o, string e = "\n") 
    {
        w.Write(o.ToString());
        w.Write(e); 
    }

    public void Enu<T>(IEnumerable<T> ea, string s = " ", string e = "\n")
    {
        foreach (var el in ea) Obj(el, e);
        Str("");
    }

    public void Dispose()
    {
        w.Close();
    }
}