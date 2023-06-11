string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

Console.WriteLine(int.Parse(num1) * Convert.ToInt32(num2[2] - '0'));
Console.WriteLine(int.Parse(num1) * Convert.ToInt32(num2[1] - '0'));
Console.WriteLine(int.Parse(num1) * Convert.ToInt32(num2[0] - '0'));
Console.WriteLine(int.Parse(num1) * int.Parse(num2));