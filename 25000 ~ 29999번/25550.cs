using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
long sum = 0;
var box = new int[n][];
for (int i = 0; i < n; i++)
    box[i] = rd.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 1; i < n - 1; i++)
    for (int j = 1; j < m - 1; j++)
        if (box[i][j] > 1)  
            sum += Math.Min(box[i][j] - 1, Math.Min(box[i - 1][j], Math.Min(box[i][j - 1], Math.Min(box[i + 1][j], box[i][j + 1]))));
wt.Write(sum);  