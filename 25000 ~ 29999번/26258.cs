using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
List<double> x = new(), y = new();    

for (int i = 0; i < n; i++)
{
    var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
    x.Add(input[0]); 
    y.Add(input[1]);
}

int m = int.Parse(rd.ReadLine());

for (int i = 0; i < m; i++)
{
    double k = double.Parse(rd.ReadLine());

    int l = 0, r = n - 1, w = 0;
    while (r > l)
    {
        w = (l + r) / 2;
        if (x[w] < k) l = w + 1;
        else r = w;
    }
    
    wt.WriteLine(y[r] - y[r - 1] == 0 ? 0 : y[r] - y[r - 1] < 0 ? -1 : 1);
}