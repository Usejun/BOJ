var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], c = 0;
var dna = Console.ReadLine();
var condition = Console.ReadLine().Split().Select(int.Parse).ToArray();
var count = new int[4];

for (int i = 0; i < m; i++)
    Add(dna[i], 1);

if (Equal()) c++;

for (int i = 0; i < n - m; i++)
{
    Add(dna[i], -1);
    Add(dna[i + m], 1);
    if (Equal()) c++;
}

Console.Write(c);

bool Equal()
{
    for (int j = 0; j < 4; j++)
        if (condition[j] > count[j])
            return false;

    return true;
}

int Add(char c, int v)
{
    if (c == 'A') return count[0] += v;
    if (c == 'C') return count[1] += v;
    if (c == 'G') return count[2] += v;
    return count[3] += v;
}