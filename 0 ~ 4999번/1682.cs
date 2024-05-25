using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var indices = new int[][]
{
   new int[]{ 7, 6, 5, 4, 3, 2, 1, 0 },
   new int[]{ 3, 0, 1, 2, 5, 6, 7, 4 },
   new int[]{ 0, 2, 5, 3, 4, 6, 1, 7 },
   new int[]{ 4, 1, 2, 3, 0, 5, 6, 7 }
};
var orignal = rd.ReadLine().Replace(" ", "");
var q = new Queue<(int count, string str)>();
var v = new HashSet<string>();

q.Enqueue((0, "12345678"));
v.Add("12345678");

while (q.TryDequeue(out var n))
{
    if (n.str == orignal)
    {
        wt.Write(n.count);
        break;
    }

    var nstrs = Next(n.str);

    foreach (var nstr in nstrs)
    {
        if (!v.Contains(nstr))
        {
            q.Enqueue((n.count + 1, nstr));
            v.Add(nstr);
        }
    }    
}

string[] Next(string root)
{
    var str = new string[4];   

    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 8; j++)
            str[i] += root[indices[i][j]];

    return str;
}