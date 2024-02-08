using Read r = new();
using Write w = new();

int n = r.Int(), INF = 98765432;
var a = new int[n][];
var dp = new int[n][];

for (int i = 0; i < n; i++)
{
    a[i] = r.Int(3);
    dp[i] = a[i].ToArray();
}

w.Obj(Math.Min(DP(0), Math.Min(DP(1), DP(2))));

int DP(int k)
{
    dp[0] = a[0].ToArray();

    for (int i = 0; i < 3; i++)
        if (i != k)
            dp[0][i] = INF;

    for (int i = 1; i < n; i++)
    {       
        dp[i][0] = Math.Min(dp[i - 1][1], dp[i - 1][2]) + a[i][0];
        dp[i][1] = Math.Min(dp[i - 1][0], dp[i - 1][2]) + a[i][1];
        dp[i][2] = Math.Min(dp[i - 1][1], dp[i - 1][0]) + a[i][2];
    }

    int m = INF;

    for (int i = 0; i < 3; i++)
        if (i != k) m = Math.Min(m, dp[n - 1][i]);

    return m;
}

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