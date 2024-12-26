using var w = new StreamWriter(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine()), MAX = 100001, MAXLV = 16;
var t = new List<int>[MAX];
var p = new int[MAX, 18];
var lv = new int[MAX];

for (int i = 0; i < MAX; i++)
	t[i] = new List<int>();

for (int i = 0; i < n - 1; i++)
{
	var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	int a = input[0], b = input[1];
	t[a].Add(b);
	t[b].Add(a);
}

SetTree(1, 0, 1);

int m = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
	var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
	int a = input[0], b = input[1];
	w.WriteLine(LCA(a, b));
}

void SetTree(int k, int pk, int l)
{
	lv[k] = l;
	p[k, 0] = pk;
	
	for (int i = 1; i <= MAXLV; i++)
		p[k, i] = p[p[k, i - 1], i - 1];
	
	for (int i = 0; i < t[k].Count; i++) {
        int c = t[k][i];
        if (c == pk) continue;
        SetTree(c, k, l + 1);
    }
}

int LCA(int a, int b)
{
	if (a == 1 || b == 1) return 1;
	int max = a, min = b;
	if (lv[a] < lv[b]) (max, min) = (b, a);
		
	if (lv[max] != lv[min]) {
        for (int i = MAXLV; i >= 0; i--) {
            if (lv[p[max, i]] >= lv[min])
                max = p[max, i];
        }
    }
	
	int v = max;
    if (max != min) {
        for (int i = MAXLV; i >= 0; i--) {
            if (p[max, i] != p[min, i]) {
                max = p[max, i];
                min = p[min, i];
            }
            v = p[max, i];
        }
    }
 
    return v;
}

 
