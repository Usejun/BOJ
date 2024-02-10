using StreamWriter sw = new(Console.OpenStandardOutput());
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], q = input[1];
var a = Console.ReadLine().Split().Select(int.Parse).OrderBy(i=>i).ToArray();

for (int i = 1; i < n; i++)
	a[i] += a[i - 1];

while (q-- > 0)
{
	input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	int l = input[0], r = input[1];
	sw.WriteLine(l - 2 < 0 ? a[r - 1] : a[r - 1] - a[l - 2]);
}