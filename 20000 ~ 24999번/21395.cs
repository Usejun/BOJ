using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int t = int.Parse(rd.ReadLine()), MAX = 150001;
var isPrime = new bool[MAX];
var primes = new List<int>();   

for (int i = 2; i < MAX; i++)
    isPrime[i] = true;

for (int i = 2; i * i < MAX; i++)
    for (int j = 2; i * j < MAX; j++)
        isPrime[i * j] = false;

for (int i = 0; i < MAX; i++)
    if (isPrime[i])
        primes.Add(i);

while (t-- > 0)
{
    int n = int.Parse(rd.ReadLine());
    var a = rd.ReadLine().Split().Select(int.Parse).OrderBy(i => i).ToArray();
    int score = int.MaxValue;

    for (int i = 0; i < primes.Count - n; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
            sum += Math.Abs(a[j] - primes[i + j]);
        score = Math.Min(score, sum);
    }
    wt.WriteLine(score);
}