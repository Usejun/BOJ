var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], c = input[1];
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
var d = new Dictionary<int, int>();

foreach (int x in a)
{
	d.TryAdd(x, 0);
	d[x]++;
}		

var b = d.OrderByDescending(i => i.Value).ToArray();

foreach ((int x, int y) in b)
	for (int i = 0; i < y; i++)
		Console.Write(x + " ");
