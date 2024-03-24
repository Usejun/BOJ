using StreamWriter w = new(Console.OpenStandardOutput());
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], a = 0;
string s = Console.ReadLine(), c = "AEIOU", last = "";

for (int i = m - 3; i < n; i++)
{
    if (s[i] == 'A') a++;
    if (a > 1 && !c.Contains(s[i]))
        last = $"{s[i]}";
}
if (string.IsNullOrEmpty(last))
    w.WriteLine("NO");
else
{
    w.WriteLine("YES");
    for (int i = 0; i < m - 3; i++)
        w.Write(s[i]);
    w.WriteLine("AA"+last);
}