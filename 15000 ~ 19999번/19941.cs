var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], l = input[1], p = 0;
var s = Console.ReadLine().ToCharArray();

for (int i = 0; i < n; i++)
    if (s[i] == 'P')    
        for (int j = (i - l) < 0 ? 0 : i - l; j <= i + l && j < n; j++)
            if (s[j] == 'H')
            {
                s[j] = 'O';
                p++;
                break;
            }

Console.Write(p);