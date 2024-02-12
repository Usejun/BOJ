var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
var graph = Enumerable.Range(0, n + 1).Select(i => new List<int>()).ToArray();
var degree = new int[n + 1];
var answer = new List<int>();
var q = new Queue<int>();

for (int i = 0; i < m; i++)
{
    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	for (int j = 2; j <= input[0]; j++)
	{
		if (!graph[input[j - 1]].Contains(input[j]))
		{
			graph[input[j - 1]].Add(input[j]);
			degree[input[j]]++;
		}
	}
}

for (int i = 1; i <= n; i++)
	if (degree[i] == 0)
		q.Enqueue(i);	
	
while (q.Count > 0)
{
	int k = q.Dequeue();

	answer.Add(k);

	foreach (var i in graph[k])
	{
		degree[i]--;
		if (degree[i] == 0)	
			q.Enqueue(i);		
	}
}

Console.Write(answer.Count != n ? 0 : string.Join("\n", answer));