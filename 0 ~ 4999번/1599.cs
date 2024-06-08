Dictionary<char, int> priority = new()
{
    { 'a', 0 }, { 'b', 1 }, { 'k', 2 }, { 'd', 3 }, { 'e', 4 }, { 'g', 5 },
    { 'h', 6 }, { 'i', 7 }, { 'l', 8 }, { 'm', 9 }, { 'n', 10 }, { 'f', 11 },
    { 'o', 12 }, { 'p', 13 }, { 'r', 14 }, { 's', 15 }, { 't', 16 }, { 'u', 17 }, 
    { 'w', 18 }, { 'y', 19 },
};

int n = int.Parse(Console.ReadLine());
var l = new List<string>();

for (int i = 0; i < n; i++)
    l.Add(Console.ReadLine().Trim());

l.Sort(Compare);

Console.Write(string.Join("\n", l));

int Compare(string a, string b)
{
    a = a.Replace("ng", "f");
    b = b.Replace("ng", "f");

    int min = Math.Min(a.Length, b.Length);

    for (int i = 0; i < min; i++)
    {
        if (priority[a[i]] < priority[b[i]]) return -1;
        else if (priority[a[i]] > priority[b[i]]) return 1;
    }

    return a.Length == b.Length ? 0 : a.Length < b.Length ? -1 : 1;
}