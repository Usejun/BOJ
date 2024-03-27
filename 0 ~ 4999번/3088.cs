using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var broken = new bool[1000001];
int n = int.Parse(rd.ReadLine()), answer = 0;

for (int i = 0; i < n; i++)
{
	bool unbroken = true;
    var input = rd.ReadLine().Split().Select(int.Parse).ToArray();
	foreach (var item in input)
	{
		if (broken[item])
			unbroken = false;
		else
			broken[item] = true;
	}
	if (unbroken)
		answer++;
}

wt.Write(answer);