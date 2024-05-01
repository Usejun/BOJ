using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int t = int.Parse(rd.ReadLine());
while (t-- > 0)
{
    var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
    int c = input[0], v = input[1];
    var vote = new int[v][];
    var like = new int[c + 1];

    for (int i = 0; i < v; i++)
    {
        vote[i] = rd.ReadLine().Split().Select(int.Parse).ToArray();
        like[vote[i][0]]++;
    }

    int max = like.Max();
    
    if (max > v / 2)    
        wt.WriteLine($"{Array.IndexOf(like, max)} 1");    
    else
    {
        int first = Array.IndexOf(like, max);
        like[first] = 0;
        int second = Array.IndexOf(like, like.Max());
        like[second] = 0;        

        for (int i = 0; i < v; i++)
            for (int j = 0; j < c; j++)
                if (vote[i][j] == first ||
                    vote[i][j] == second)
                {
                    like[vote[i][j]]++;
                    break;
                }

        wt.WriteLine($"{(like[first] > like[second] ? first : second)} 2");
    }
}