int n = 10, min = int.MaxValue;
var map = new int[n][];
var paper = new int[6];

for (int i = 1; i < 6; i++)
    paper[i] = 5;

for (int i = 0; i < n; i++)
    map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();

Search(0, 0);

Console.Write(min == int.MaxValue ? -1 : min);

void Search(int x, int count)
{
    if (count >= min) return;

    bool flag = false;

    for (int i = x; !flag && i < n; i++)
    {
        for (int j = 0; !flag && j < n; j++)
        {
            if (map[i][j] == 1)
            {
                flag = true;

                int size = Math.Min(5, Math.Min(Left(i, j), Math.Min(Down(i, j), Diagonal(i, j))));
                for (int k = size; k > 0; k--)
                {
                    if (paper[k] != 0 && Able(i, j, k))
                    {
                        paper[k]--;
                        Put(i, j, k);
                        Search(i, count + 1);
                        Remove(i, j, k);
                        paper[k]++;
                    }
                }
            }
        }
    }

    if (!flag)
        min = Math.Min(count, min);
}

int Left(int x, int y)
{
    int len = 0;
    for (int i = y; i < n; i++)
        if (map[x][i] == 1)
            len++;
    return len;    
}

int Down(int x, int y)
{
    int len = 0;
    for (int i = x; i < n; i++)
        if (map[i][y] == 1)
            len++;
    return len;
}

int Diagonal(int x, int y)
{
    int len = 0;
    for (int i = 0; x + i < n && y + i < n; i++)
        if (map[x + i][y + i] == 1)
            len++;
    return len;
}

void Put(int x, int y, int size)
{
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            map[x + i][y + j] = 2;
}

bool Able(int x, int y, int size)
{
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            if (map[x + i][y + j] != 1) return false;
    return true;
}

void Remove(int x, int y, int size)
{
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            map[x + i][y + j] = 1;
}