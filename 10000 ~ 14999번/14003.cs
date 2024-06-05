int n = int.Parse(Console.ReadLine()), idx, len;
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
List<int> list = new() { a[0] }, index = new() { 0 }, answer = new();

for (int i = 1; i < n; ++i)
{
    if (a[i] > list[^1])
    {
        list.Add(a[i]);
        index.Add(list.Count - 1);
    }
    else
    {
        idx = (idx = list.BinarySearch(a[i])) < 0 ? -idx - 1 : idx;
        list[idx] = a[i];
        index.Add(idx);
    }
}

len = list.Count - 1;

for (int i = n - 1; i >= 0; --i)
    if (index[i] == len)
    {
        answer.Add(a[i]);
        len--;
    }

Console.WriteLine(answer.Count);
Console.WriteLine(string.Join(" ", answer.Reverse<int>()));