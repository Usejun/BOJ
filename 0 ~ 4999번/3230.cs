using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
var ranking = new List<int>();
var medal = new List<int>();

for (int i = 0; i < n; i++)
{
    int rank = int.Parse(rd.ReadLine());
    if (rank - 1 == ranking.Count) ranking.Add(i + 1); 
    else ranking.Insert(rank - 1, i + 1);   
}

ranking = ranking.Take(m).ToList();

for (int i = 1; i <= m; i++)
{
    int rank = int.Parse(rd.ReadLine());
    if (rank - 1 == medal.Count) medal.Add(ranking[^i]);
    else medal.Insert(rank - 1, ranking[^i]);
}

wt.Write(string.Join('\n', medal.Take(3)));