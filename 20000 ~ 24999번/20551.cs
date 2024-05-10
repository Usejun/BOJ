using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
var l = new List<int>();

for (int i = 0; i < n; i++)
    l.Add(int.Parse(rd.ReadLine()));

l.Sort();

while (m-- > 0)
{
    int start = 0, mid = 0, end = n, k = int.Parse(rd.ReadLine()); ;
    while (start < end)
    {
        mid = (start + end) / 2;
        if (l[mid] < k) start = mid + 1;
        else end = mid;
    }

    wt.WriteLine(end >= n || l[end] != k ? -1 : end);
}