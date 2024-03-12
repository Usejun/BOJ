int n = int.Parse(Console.ReadLine());
var l = new List<string>();
var s = "";
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine();
    foreach (var c in input)
    {
        if (char.IsDigit(c))
        {
            bool zero = true;  
            foreach (var z in s)
                if (z != '0')
                {            
                    zero = false;
                    break;
                }
            s = zero ? "" + c : s + c;            
        }
        else if (!string.IsNullOrEmpty(s))
        {
            l.Add(s);
            s = "";
        }
    }    
    if (!string.IsNullOrEmpty(s))
    {
        l.Add(s);
        s = "";
    }
}
l.Sort((i, j) => i.Length == j.Length ? string.Compare(i, j) : i.Length - j.Length);
Console.Write(string.Join("\n", l));