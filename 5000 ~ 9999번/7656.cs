using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var str = rd.ReadLine();
int cur = 0, len = str.Length;
while ((cur = str.IndexOf("What is", cur)) != -1)
{
    int per = str.IndexOf('.', cur);
    int que = str.IndexOf('?', cur);
    if (str.Substring(cur, que - cur + 1).IndexOf('.') != -1)
    {
        cur = per;
        continue;
    }

    wt.Write("Forty-two is");
    cur += 7;
	while (cur < len && str[cur] != '?')
		wt.Write(str[cur++]);
    wt.Write(".\n");
    cur++;
}