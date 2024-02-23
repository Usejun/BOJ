var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = input[0], M = input[1];
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var s = new long[N + 1];
var m = new long[M + 1];
long c = 0;	

for (int i = 1; i <= N; i++)
{
	if ((s[i] = (s[i - 1] + a[i - 1]) % M) == 0) c++;
	m[s[i]]++;	
}

for (int i = 0; i < M; i++)
	c += m[i] <= 1 ? 0 : m[i] * (m[i] - 1) / 2;

Console.Write(c);