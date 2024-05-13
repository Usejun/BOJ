using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var s = rd.ReadLine();
int i = -1;
long a = 0, b = 0, c = 0;

for (i = 1; i < s.Length; i++)
{
    if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/')
    {
        if (s[0] == '-')
            a = -Convert.ToInt32(s.Substring(1, i - 1), 8);
        else a = Convert.ToInt32(s.Substring(0, i), 8);
        if (s[i + 1] == '-')
            b = -Convert.ToInt32(s.Substring(i + 2), 8);
        else b = Convert.ToInt32(s.Substring(i + 1), 8);
        break;
    }
}

if (s[i] == '+') c = a + b;
if (s[i] == '-') c = a - b;
if (s[i] == '*') c = a * b;
if (s[i] == '/') c = b == 0 ? int.MinValue : (int)Math.Floor((double)a / b);

wt.Write(c == int.MinValue ? "invalid" : c < 0 ? "-" + Convert.ToString(-c, 8) : Convert.ToString(c, 8));