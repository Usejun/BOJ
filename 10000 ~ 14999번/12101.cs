using System.Text;
using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], k = input[1], d = 0;

Sum(new StringBuilder().Append('1'), 1);
Sum(new StringBuilder().Append('2'), 2);
Sum(new StringBuilder().Append('3'), 3);
wt.Write(-1);

void Sum(StringBuilder sb, int sum)
{
    if (sum > n) return;
    if (sum == n)
    {
        d++;
        if (d == k)
        {
            wt.Write(sb);
            wt.Close();
            Environment.Exit(0);
        }
    }

    sb.Append("+1");
    Sum(sb, sum + 1);
    sb.Remove(sb.Length - 2, 2);
    sb.Append("+2");
    Sum(sb, sum + 2);
    sb.Remove(sb.Length - 2, 2);
    sb.Append("+3");
    Sum(sb, sum + 3);
    sb.Remove(sb.Length - 2, 2);
}