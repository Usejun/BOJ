using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int t = int.Parse(rd.ReadLine());
while (t-- > 0)
{
    long n = int.Parse(rd.ReadLine()), k = 0;

    for (int i = 5; i <= n; i*=5) 
        k += n / i;

    wt.WriteLine(k);    
} 