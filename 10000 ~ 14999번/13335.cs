var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int N = input[0], M = input[1], W = input[2], T = 0;
Queue<int> q1 = new(Console.ReadLine().Split().Select(int.Parse)), q2 = new(Enumerable.Repeat(0, M));

while (q2.TryDequeue(out _))
{
    T++;
    if (q1.TryPeek(out var k)) 
        q2.Enqueue(q2.Sum() + k <= W ? q1.Dequeue() : 0);
}

Console.Write(T);