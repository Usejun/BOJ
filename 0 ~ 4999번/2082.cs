var time = new string[10][]
{
   new string[] { "###", "#.#", "#.#", "#.#", "###"},
   new string[] { "..#", "..#", "..#", "..#", "..#" },
   new string[] { "###", "..#", "###", "#..", "###" },
   new string[] { "###", "..#", "###", "..#", "###" },
   new string[] { "#.#", "#.#", "###", "..#", "..#" },
   new string[] { "###", "#..", "###", "..#", "###" },
   new string[] { "###", "#..", "###", "#.#", "###" },
   new string[] { "###", "..#", "..#", "..#", "..#" },
   new string[] { "###", "#.#", "###", "#.#", "###" },
   new string[] { "###", "#.#", "###", "..#", "..#" }
};

var input = new string[4][];

for (int i = 0; i < 4; i++) input[i] = new string[5];

for (int i = 0; i < 5; i++)
{
	var str = Console.ReadLine().Split();	
	for (int j = 0; j < 4; j++)	
		input[j][i] = str[j];	
}

Console.Write($"{Time(input[0], input[1], 0, 23):00}:{Time(input[2], input[3], 0, 59):00}");

int Time(string[] n1, string[] n2, int a, int b)
{
	int i = a;
	for (; i < b; i++)
	{
		int t1 = i / 10, t2 = i % 10;
		bool able = true;

		for (int j = 0; able && j < 5; j++)
		{
			for (int k = 0; k < 3; k++)
			{
				if (n1[j][k] == '#' && time[t1][j][k] == '.' || n2[j][k] == '#' && time[t2][j][k] == '.')
				{
					able = false;
					break;
				}
			}
		}

		if (able) break;
	}
	return i;
}
