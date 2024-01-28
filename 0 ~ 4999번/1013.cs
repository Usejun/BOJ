int n = int.Parse(Console.ReadLine());
while (n-- > 0)
{
    Console.WriteLine(Regex(Console.ReadLine(), 0) ? "YES" : "NO");
    bool Regex(string input, int index)
    {
        if (index >= input.Length) return true;

        if (input.Length >= index + 2 && input.Substring(index, 2) == "01") return Regex(input, index + 2);
        else if (input.Length > index + 3 && input.Substring(index, 3) == "100")
        {
            index += 3;
            while (input[index] == '0')
            {
                index++;
                if (index >= input.Length) return false;
            }
            if (input[index] == '1') index++;
            else return false;
            if (index >= input.Length) return true;
            while (input[index] == '1')
            {
                if (input.Length >= index + 3 && input.Substring(index, 3) == "100") return Regex(input, index);
                else index++;
                if (index >= input.Length) return true;
            }
            return Regex(input, index);
        }
        else return false;
    }
}