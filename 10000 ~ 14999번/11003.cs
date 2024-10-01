using StreamWriter sw = new(Console.OpenStandardOutput());
var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], l = input[1];
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var pq = new PriorityQueue<(int v, int i), int>();

for (int i = 0; i < n; i++)
{
	pq.Enqueue((a[i], i), a[i]);
	while (pq.Peek().i <= i - l) 
		pq.Dequeue();
	sw.Write(pq.Peek().v);
	sw.Write(" ");
}
