using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int t = int.Parse(rd.ReadLine());
while (t-- > 0)
{
    rd.ReadLine();
    var input = rd.ReadLine().Split().Select(long.Parse).ToArray();  
    long[] size = { input[0], input[1], input[2] };
    Array.Sort(size);
    long a = size[0], b = size[1], c = size[2], d = input[3];
  
    long sum = a + b + c - d, av = Math.Min(sum / 3, a);
    long i = av, j = Math.Min((sum - av) / 2, b);
    wt.WriteLine(i * j * (sum - av - j));
}