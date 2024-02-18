using static System.Console;
int n = int.Parse(ReadLine()), m = int.Parse(ReadLine());
var f = Enumerable.Range(0, 501).Select(i => new int[501]).ToArray();
Enumerable.Range(0, m).Select(i => ReadLine().Split().Select(int.Parse).ToList()).Select(i => (f[i[0]][i[1]] = 1) == (f[i[1]][i[0]] = 1)).ToList();
f[1].Select((i, j) => i == 1 && (f[0][j] = 1) == 1 ? f[j].Select((k, q) => k == 1 && ((f[0][q] = 1) == 1)).ToList() : new List<bool>()).ToList();
Write(f[0].Sum() == 0 ? 0 : f[0].Sum() - 1);