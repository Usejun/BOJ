int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
var l = new List<int>();

for (int i = 0; i < n; i++)
    l.Insert(a[i], n - i);

Console.Write(string.Join(" ", l));