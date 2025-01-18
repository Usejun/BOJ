var input = Console.ReadLine().Split();
(int x, int y) king = (input[0][0]-'A', input[0][1]-'1');
(int x, int y) stone = (input[1][0]-'A', input[1][1]-'1');
var n = int.Parse(input[2]);

while (n-- > 0)
{
	int x = 0, y = 0;
	var key = Console.ReadLine();
	
	if (key[0] == 'R') x = 1;
	else if (key[0] == 'L') x = -1;
	else if (key[0] == 'B') y = -1;
	else if (key[0] == 'T') y = 1;
	
	if (key.Length == 2)
	{
		if (key[1] == 'B') y = -1;
		else y = 1;
	}
	var v1 = Move(king, x, y);
	var v2 = Move(stone, x, y);
	if (v1 == stone)
		stone = v2;
	if (v1 != stone)
		king = v1;
}

Console.Write($"{(char)(king.x + 'A')}{king.y+1}\n{(char)(stone.x + 'A')}{stone.y+1}");

(int x, int y) Move((int x, int y) pair, int a, int b)
{
	(int x, int y) = (pair.x + a, pair.y + b);
	if (x < 0 || y < 0 || x > 7 || y > 7) return pair;
	return (x, y);
}
