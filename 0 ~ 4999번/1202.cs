var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], k = input[1];
PriorityQueue<int, int> pq = new();
List<int> bag = new();
List<(int v, int m)> jewelry = new();

for (int i = 0; i < n; i++)
{
    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int m = input[0], v = input[1];

    jewelry.Add((v, m));
}

for (int i = 0; i < k; i++)
    bag.Add(int.Parse(Console.ReadLine()));

bag.Sort();
jewelry.Sort((i, j) =>
    i.m == j.m ? i.v.CompareTo(j.v) : i.m.CompareTo(j.m)
);

int index = 0;
long sum = 0;

for (int i = 0; i < k; i++)
{
    while (index < n && bag[i] >= jewelry[index].m)
    {
        pq.Enqueue(jewelry[index].v, -jewelry[index].v);
        index++;
    }
    if (pq.Count > 0)    
        sum += pq.Dequeue();    
}

Console.WriteLine(sum);