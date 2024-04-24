using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine()), max = 0, cA = 0, cB = 0;
var a = rd.ReadLine().Split().Select(int.Parse).ToArray();
var b = rd.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < n; i++)
{
    if (a[i] == b[i]) (cA, cB) = cA != 0 ? (0, cB + 1) : (cA + 1, 0);
    else if (a[i] == 1 && b[i] == 3) (cA, cB) = (cA + 1, 0);
    else if (a[i] == 2 && b[i] == 1) (cA, cB) = (cA + 1, 0);
    else if (a[i] == 3 && b[i] == 2) (cA, cB) = (cA + 1, 0);
    else if (b[i] == 1 && a[i] == 3) (cA, cB) = (0, cB + 1);
    else if (b[i] == 2 && a[i] == 1) (cA, cB) = (0, cB + 1);
    else if (b[i] == 3 && a[i] == 2) (cA, cB) = (0, cB + 1);
    max = Math.Max(max, Math.Max(cA, cB));
}

wt.Write(max);