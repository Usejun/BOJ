int k = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
var h = Enumerable.Range(0, 9).Select(i => new HashSet<int>()).ToArray();

for (int i = 1, j = k; i <= 8; i++, j = j * 10 + k)
    DP(j, i);

for (int i = 1; i < 8; i++)
    for (int j = 1; i + j <= 8; j++)   
        foreach (int a in h[i])        
            foreach (int b in h[j])
            {
                h[i + j].Add(a + b);
                h[i + j].Add(a - b);
                h[i + j].Add(b - a);
                h[i + j].Add(a * b);
                if (b != 0) h[i + j].Add(a / b);
                if (a != 0) h[i + j].Add(b / a);
            }

while (n-- > 0)
{
    int a = int.Parse(Console.ReadLine()), l = 9;
    for (int i = 1; l > 8 && i <= 8; i++)    
        if (h[i].Contains(a))        
            l = i;
    Console.WriteLine(l > 8 ? "NO" : l);
}

void DP(int sum, int depth)
{
    h[depth].Add(sum);
    if (depth == 8) return;
    DP(sum + k, depth + 1);
    DP(sum - k, depth + 1);
    DP(sum * k, depth + 1);
    DP(sum / k, depth + 1);
}