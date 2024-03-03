using StreamWriter w = new(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var s = new int[n + 1];

for (int i = 1; i <= n; i++)
    s[i] = s[i - 1] + a[i - 1];

int k = int.Parse(Console.ReadLine());
while (k-- > 0)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int i = input[0], j = input[1];
    w.WriteLine(s[j] - s[i - 1]);
}