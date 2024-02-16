using static System.Console;
int t = int.Parse(ReadLine());
while (t-- > 0)
{
    long n = int.Parse(ReadLine()), k = 0;
    var pq = new PriorityQueue<long, long>();
    var v = ReadLine().Split().Select(long.Parse);
    pq.EnqueueRange(v.Zip(v));

    while (pq.Count > 1)
    {
        long a = pq.Dequeue() + pq.Dequeue();
        k += a;
        pq.Enqueue(a, a);
    }
    WriteLine(k);
}