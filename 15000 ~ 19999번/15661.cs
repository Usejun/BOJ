int n = int.Parse(Console.ReadLine());
var status = new int[n][];
int min = int.MaxValue;
var team = new bool[n];

for (int i = 0; i < n; i++)
    status[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

Solve(0, 0);

Console.Write(min);

void Solve(int person, int depth)
{
    Calc();
    if (depth > n / 2 || min == 0) return; 

    for (int i = person; i < n; i++)
    {
        team[i] = true;
        Solve(i + 1, depth + 1);
        team[i] = false;
    }
}

void Calc() 
{
    int s = 0, l = 0;

    for (int i = 0; i < n - 1; i++)
        for (int j = i + 1; j < n; j++)
            if (team[i] && team[j])        s += status[i][j] + status[j][i];
            else if (!team[i] && !team[j]) l += status[i][j] + status[j][i];

    min = Math.Min(Math.Abs(s - l), min);
}