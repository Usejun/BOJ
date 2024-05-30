using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int t = int.Parse(rd.ReadLine());

while (t-- > 0)
{
    int n = int.Parse(rd.ReadLine());
    var a = new HashSet<int>(rd.ReadLine().Split().Select(int.Parse).ToArray());
    int m = int.Parse(rd.ReadLine());
    var b = new HashSet<int>(rd.ReadLine().Split().Select(int.Parse).ToArray());
    int k = int.Parse(rd.ReadLine());
    var c = new HashSet<int>(rd.ReadLine().Split().Select(int.Parse).ToArray());
    var count = new HashSet<int>();

    foreach (var av in a)
        foreach (var bv in b)
            foreach (var cv in c)
                if (Valid(av + bv + cv)) 
                    count.Add(av + bv + cv);

    wt.WriteLine(count.Count);
}

bool Valid(int n)
{
    while (n > 0)
    {
        if (n % 10 != 5 && n % 10 != 8) return false;
        n /= 10;
    }

    return true;
}