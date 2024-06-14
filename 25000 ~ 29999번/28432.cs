int n = int.Parse(Console.ReadLine()), idx = -1;
List<string> s = new(), a = new();    

for (int i = 0; i < n; i++)
{
    var t = Console.ReadLine();
    if (t == "?") idx = i;
    s.Add(t); 
}

char first = idx - 1 < 0 ? '\0' : s[idx - 1][^1], last = idx + 1 >= n ? '\0' : s[idx + 1][0]; 

int m = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    var t = Console.ReadLine();
    if (!s.Contains(t) && (t[0] == first || first == '\0') && (t[^1] == last || last == '\0'))
    {
        Console.WriteLine(t);
        break;
    }    
}