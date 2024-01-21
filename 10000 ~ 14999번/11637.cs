int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    var l = new List<int>();

    for (int i = 0; i < n; i++)
        l.Add(int.Parse(Console.ReadLine()));

    Console.WriteLine($"{(l.Count(i => i == l.Max()) > 1 ? "no" : l.Sum() / 2 >= l.Max() ? "minority" : "majority")} winner {(l.Count(i => i == l.Max()) == 1 ? l.IndexOf(l.Max()) + 1 : "")}");
}