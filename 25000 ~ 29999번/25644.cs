int n = int.Parse(Console.ReadLine()), max = 0, price = 0;
var a = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = n - 1; i >= 0; --i)
{
    max = Math.Max(max, a[i]);
    price = Math.Max(price, max - a[i]);
}

Console.Write(price);