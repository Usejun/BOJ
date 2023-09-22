using System.Text;
using static System.Console;

var max = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => 
{ 
    if (x > y)
        return -1;
    if (x == y)
        return 0;
    return 1;
}));
var min = new PriorityQueue<int, int>();
var count = new Dictionary<int, int>();
var sb = new StringBuilder();

int t = int.Parse(ReadLine()), k, n;
string command;
while (t-- > 0)
{
    max.Clear();
    min.Clear();
    count.Clear();

    k = int.Parse(ReadLine());
    while (k-- > 0)
    {
        var input = ReadLine().Split();
        command = input[0];
        n = int.Parse(input[1]);

        if (command == "I")
        {
            max.Enqueue(n, n);
            min.Enqueue(n, n);
            if (!count.ContainsKey(n))
                count.Add(n, 0);
            count[n]++;
        }
        else
        {
            if (n == 1 && max.Count != 0)
            {
                count[max.Peek()]--;
                max.Dequeue();
            }
            else if (n == -1 && min.Count != 0)
            {
                count[min.Peek()]--;
                min.Dequeue();
            }

            while (min.Count != 0 && count[min.Peek()] == 0) min.Dequeue();
            while (max.Count != 0 && count[max.Peek()] == 0) max.Dequeue();
        }

        while (min.Count != 0 && count[min.Peek()] == 0) min.Dequeue();
        while (max.Count != 0 && count[max.Peek()] == 0) max.Dequeue();

    }

    if (min.Count == 0 || max.Count == 0)
        sb.Append("EMPTY\n");
    else
        sb.Append($"{max.Peek()} {min.Peek()}\n");
}
Write(sb);
