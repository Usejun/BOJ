int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).OrderBy(i => i).ToArray();
int m = -1;
foreach (var i in a)
    m = Math.Max(m, a.Count(j => i == j));
Console.Write(m);
