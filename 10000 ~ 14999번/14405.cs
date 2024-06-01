using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
var str = rd.ReadLine();
var flag = true;
var len = str.Length;

for (int i = 0; flag && i < len; i++)
{
    if (str[i] == 'p')
    {
        if (i + 1 < len && str[i + 1] == 'i') i++;
        else flag = false;
    }
    else if (str[i] == 'k')
    {
        if (i + 1 < len && str[i + 1] == 'a') i++;
        else flag = false;
    }
    else if (str[i] == 'c')
    {
        if (i + 1 < len && str[i + 1] == 'h')
        {
            if (i + 2 < len && str[i + 2] == 'u') i += 2;
            else flag = false;
        }
        else flag = false;
    }
    else flag = false;
}

wt.Write(flag ? "YES" : "NO");