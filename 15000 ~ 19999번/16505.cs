using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine()), m = 1 << n, w = m;
var buf = new char[m, m];

Write(0, 0, m);

for (int i = 0; i < m; i++)
{
	for (int j = 0; j < w; j++)	
		wt.Write(buf[i, j] == '\0' ? ' ' : '*');	
	w--;
	wt.Write('\n');
}

void Write(int x, int y, int size)
{
	if (size == 1)
	{
        buf[x, y] = '*';
		return;
	}

	int k = size >> 1;

    Write(x, y, k);
    Write(x + k, y, k);
    Write(x, y + k, k);
}