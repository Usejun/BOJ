Dictionary<char, string> d = new()
{
    { '0', "z" },  { '1', "o" },  { '2', "tw" }, 
    { '3', "th" }, { '4', "fo" }, { '5', "fi" }, 
    { '6', "si" }, { '7', "se" }, { '8', "e"},
    { '9', "n" }
};

var input = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
int n = input[0], m = input[1];
List<(int i, string s)> l = new();

for (int i = n; i <= m; i++)
    l.Add((i, string.Join("", i.ToString().Select(i => d[i]))));
var t = l.OrderBy(i => i.s).Select(i => i.i).ToArray();

for (int i = 1; i * 10 <= l.Count + 10; i++)
    Console.WriteLine(string.Join(" ", t.Skip((i - 1) * 10).Take(10)));