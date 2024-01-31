using static System.Console;
var input = ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], c = 0;
var s = ReadLine().Split().Select(int.Parse).ToArray();
var h = new List<int>[n + 1];
var known = new bool[n + 1];
var p = new int[m][];

for (int i = 0; i < m; i++)
    p[i] = ReadLine().Split().Select(int.Parse).Skip(1).ToArray();

for (int i = 0; i <= n; i++)
    h[i] = new();

for (int i = 0; i < m; i++)
    foreach (var j in p[i])
        h[j].AddRange(p[i]);

for (int i = 1; i <= s[0]; i++) 
    D(s[i]);

for (int i = 0; i < m; i++)
{
    bool f = false;
    foreach (var j in p[i])    
        f = f || known[j];    
    c = f ? c : c + 1;
}

Write(c);

void D(int k)
{
    known[k] = true;
    foreach (var i in h[k])
        if (!known[i]) D(i);
}