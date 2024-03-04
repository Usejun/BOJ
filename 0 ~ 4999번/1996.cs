using StreamWriter w = new(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine());
var map = new string[n];
var board = new int[n, n];
var d = new (int x, int y)[] { (0, 1), (1, 0), (-1, 0), (0, -1), (-1, -1), (-1, 1), (1, -1), (1, 1) };
for (int i = 0; i < n; i++)
    map[i] = Console.ReadLine();

for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        for (int k = 0; k < 8; k++)
        {
            int x = i + d[k].x, y = j + d[k].y;
            if (x < 0 || y < 0 || x >= n || y >= n || map[i][j] < '1')
                continue;
            board[x, y] += map[i][j] - '0';
        }

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
        w.Write(map[i][j] != '.' ? '*' : board[i, j] >= 10 ? 'M' : (char)(board[i, j] + '0'));
    w.WriteLine();
}