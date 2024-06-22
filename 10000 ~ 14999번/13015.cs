int n = int.Parse(Console.ReadLine()), m = n - 2, k = 2 * n - 1, c = 2 * m + 1;
string border = $"{new string('*', n)}{new string(' ', c)}{new string('*', n)}";
string empty = new(' ', m);

Console.WriteLine(border);
Console.Write(n != 2 ? string.Join('\n', Enumerable.Range(1, n - 2).Select(i => $"{new string(' ', i)}*{empty}*{new string(' ', c - 2 * i)}*{empty}*")) + "\n" : "");
Console.WriteLine($"{new string(' ', n - 1)}*{empty}*{empty}*");
Console.Write(n != 2 ? string.Join('\n', Enumerable.Range(1, n - 2).Select(i => $"{new string(' ', i)}*{empty}*{new string(' ', c - 2 * i)}*{empty}*").Reverse()) + "\n" : "");
Console.WriteLine(border);