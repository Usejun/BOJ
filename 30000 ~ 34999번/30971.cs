using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var f = () => rd.ReadLine().Split().Select(int.Parse).ToArray();
int[] input = f(), a = f(), b = f(), c = f(), d = new int[10];
var v = new bool[10];
int n = input[0], k = input[1], max = 0;
Search(0);
wt.Write(max == 0 ? -1 : max);

void Search(int depth)
{
    if (n == depth)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (c[d[i - 1]] * c[d[i]] <= k)
                sum += a[d[i - 1]] * b[d[i]];
            else
            {
                sum = 0;
                break;
            }
        }
        max = Math.Max(max, sum);

        return;
    }

    for (int i = 0; i < n; i++)
    {
        if (!v[i])
        {
            v[i] = true;
            d[depth] = i;
            Search(depth + 1);
            v[i] = false;
        }
    }
}