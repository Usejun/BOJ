using StreamWriter sw = new(Console.OpenStandardOutput());
int N = 1000001;
var dp = new long[N];

for (int i = 1; i < N; i++)
{
	for (int j = 1; i * j < N; j++)	
		dp[i * j] += i;	
	dp[i] += dp[i - 1];
}

int n = int.Parse(Console.ReadLine());
while (n-- > 0)
	sw.WriteLine(dp[int.Parse(Console.ReadLine())]);