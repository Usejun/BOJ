var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1];
var map = new int[n, m];
var cctv = new List<(int x, int y, int type)>();
var move = new (int x, int y)[] {(-1, 0), (0, 1), (1, 0), (0, -1) };
var direction = new int[6][][]
{
	new int[][] { },
    new int[4][] { new int[]{0}, new int[]{1}, new int[]{2}, new int[]{3} },
    new int[2][] { new int[]{0 , 2}, new int[]{1, 3} },
    new int[4][] { new int[]{0 , 1}, new int[]{1 , 2}, new int[]{2 , 3}, new int[]{3 , 0},},
    new int[4][] { new int[]{3, 0, 1}, new int[]{0, 1, 2}, new int[]{1, 2, 3}, new int[]{2, 3, 0}, },
    new int[1][] { new int[]{0, 1, 2, 3}},
};
int min = int.MaxValue;

for (int i = 0; i < n; i++)
{
	input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	for (int j = 0; j < m; j++)
	{
		if (input[j] > 0 && input[j] < 6)
			cctv.Add((i, j, input[j]));
		map[i, j] = input[j];
	}
}

Search(map, 0);

Console.Write(min);

void Search(int[,] board, int k)
{
	if (k == cctv.Count)
		min = Math.Min(min, Count(board));
	else
	{
		foreach (var dir in direction[cctv[k].type])
			Search(Watch((int[,])board.Clone(), cctv[k].x, cctv[k].y, dir), k + 1);		
	}
}

int Count(int[,] board)
{
	int count = 0;

    Console.WriteLine();

    for (int i = 0; i < n; i++)
	{
        for (int j = 0; j < m; j++)
		{
			Console.Write(board[i, j] + " ");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < n; i++)
		for (int j = 0; j < m; j++)
			if (board[i, j] == 0)
				count++;

	return count;
}

int[,] Watch(int[,] board, int x, int y, int[] direction)
{
	foreach (var dir in direction)
	{
		int nx = x, ny = y;

		while (true)
		{
			nx += move[dir].x;
			ny += move[dir].y;

			if (nx < 0 || nx >= n || ny < 0 || ny >= m || board[nx, ny] == 6) break;

			if (board[nx, ny] == 0)
				board[nx, ny] = 1;
		}
	}

	return board;
}