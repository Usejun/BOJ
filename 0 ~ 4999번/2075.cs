int n = int.Parse(Console.ReadLine()), k = n;  
var pq = new PriorityQueue<int, int>();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    pq.EnqueueRange(input.Zip(input));
    while (pq.Count > k) pq.Dequeue(); 
}
Console.Write(pq.Dequeue());
