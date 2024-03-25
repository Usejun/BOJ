using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());

int r = int.Parse(rd.ReadLine());
int n = int.Parse(rd.ReadLine());
int a = n - 1, b = n - r, c = a - b;

long s = 1;

while (a > 0)
{
    s *= a--;
    while (b != 0 && s % b == 0) s /= b--;
    while (c != 0 && s % c == 0) s /= c--;
}

while (b > 0) s /= b--;
while (c > 0) s /= c--;

wt.Write(s);