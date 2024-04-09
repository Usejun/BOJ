using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int t = int.Parse(rd.ReadLine()), MAX = 100001;
var q = new Queue<int>();
var v = new int[MAX];

while (t-- > 0)
{
    int k = int.Parse(rd.ReadLine());
    q.Clear();
    for (int i = 0; i < MAX; i++)
        v[i] = int.MaxValue;
    q.Enqueue(1);
    v[1] = 0;

    while (q.TryDequeue(out var n))
    {
        if (n - 1 > 0 && v[n - 1] > v[n] + 1)
        {
            v[n - 1] = v[n] + 1;
            q.Enqueue(n - 1);
        }
        if (2 * n < MAX && v[2 * n] > v[n] + 1)
        {
            v[2 * n] = v[n] + 1;
            q.Enqueue(2 * n);
        }
    }

    wt.WriteLine(v[k]);
}
