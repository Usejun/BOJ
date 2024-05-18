using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(rd.ReadLine()), l = -1, k = 0;
var s = new List<string>();

var a = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
var b = new string[] { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
var c = new string[] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
var h = "hundred";

for (int i = 0; i < n; i++)
{
    s.Add(rd.ReadLine());
    l += s[^1].Length;
}

for (int i = l + 1; i < 1000; i++)
{
    string v = "";
    if (i <= 10) v = a[i];
    else if (i < 20) v = b[i % 10];
    else if (i < 100) v = c[i / 10] + a[i % 10];
    else if (i % 100 > 10 && i % 100 < 20) v = a[i / 100] + h + b[i % 10];
    else v = a[i / 100] + h + c[i / 10 % 10] + a[i % 100 == 10 ? 10 : i % 10];

    if (l + v.Length == i)
    {
        for (int j = 0; j < n; j++) wt.Write((s[j] == "$" ? v : s[j]) + " ");
        break;
    }
}