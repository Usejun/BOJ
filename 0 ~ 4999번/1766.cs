var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
var l = Enumerable.Range(0, n + 1).Select(i => new List<int>()).ToArray();
var d = new int[n + 1];
var pq = new PriorityQueue<int, int>(); 

for (int i = 0; i < m; i++)
{
    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    l[input[0]].Add(input[1]);
    d[input[1]]++;
}

for (int i = 1; i <= n ; i++)
    if (d[i] == 0)
        pq.Enqueue(i, i);   

while (pq.Count > 0)
{
    int k = pq.Dequeue();
    Console.Write(k + " ");
    foreach (var i in l[k])
    {
        d[i]--;
        if (d[i] == 0)
            pq.Enqueue(i, i);
    }
}