using static System.Console;
using System.Text;
var sb = new StringBuilder();
var pq = new PriorityQueue<int, int>();
int n = int.Parse(ReadLine()), x;
while (n-- > 0)
{
    x = int.Parse(ReadLine());
    if (x != 0) pq.Enqueue(x, Math.Abs(x) * 2 - (x < 0 ? 1 : 0));
    else sb.Append($"{(pq.Count == 0 ? 0 : pq.Dequeue())}\n");
}
Write(sb);
