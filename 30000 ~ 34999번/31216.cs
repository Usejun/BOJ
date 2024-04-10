using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int MAX = 500001;
var isPrime = new bool[MAX];
var primes = new List<int>();
var superPrimes = new List<int>();

for (int i = 0; i < MAX; i++)
    isPrime[i] = true;

isPrime[0] = false;
isPrime[1] = false;

for (int i = 2; i * i < MAX; i++)
    for  (int j = 2; i * j < MAX; j++)
        isPrime[i * j] = false;

for (int i = 2; i < MAX; i++)
    if (isPrime[i]) 
        primes.Add(i);

for (int i = 0; i < primes.Count; i++)
    if (isPrime[i])
        superPrimes.Add(primes[i - 1]);

int n = int.Parse(rd.ReadLine());

while (n-- > 0)
    wt.WriteLine(superPrimes[int.Parse(rd.ReadLine()) - 1]);