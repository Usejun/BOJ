var S = Console.ReadLine();
var T = Console.ReadLine();
var l = new List<char>(T);

while (true)
{
    if (l.Count == S.Length)
        break;

    if (l[l.Count - 1] == 'A')
        l.RemoveAt(l.Count - 1);
    else
    {
        l.RemoveAt(l.Count - 1);
        l.Reverse();
    }
}

Console.Write(string.Join("", l) == S ? 1 : 0);