using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine());
var a = rd.ReadLine().Split().Select(int.Parse).ToArray();
var tree = Enumerable.Repeat(-2, 200001).ToArray();
int count = 0, i = 1, j = 0;
tree[a[0]] = -1;

for (; i < n; i++)
    if (tree[a[i]] == -2)
        tree[a[i]] = a[i - 1];

while (tree[j++] != -2)
    count++;

wt.WriteLine($"{count}\n{string.Join(" ", tree.Take(count))}");