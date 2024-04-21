using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var input = rd.ReadLine().Trim().Split().Select(int.Parse).ToArray();
int n = input[0], m = input[1], count = 0;
var image = new int[n][];

for (int i = 0; i < n; i++)
    image[i] = rd.ReadLine().Trim().Split().Select(int.Parse).ToArray();

int k = int.Parse(rd.ReadLine().Trim());

for (int i = 0; i <= n - 3; i++)
{
	for (int j = 0; j <= m - 3; j++)
	{
		var pixel = new int[9] { image[i][j], image[i + 1][j], image[i + 2][j],
                                 image[i][j + 1], image[i + 1][j + 1], image[i + 2][j + 1],
							     image[i][j + 2], image[i + 1][j + 2], image[i + 2][j + 2],};
		
		Array.Sort(pixel);
		count = pixel[4] >= k ? count + 1 : count;
	}
}
wt.Write(count);
