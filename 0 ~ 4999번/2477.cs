int k = int.Parse(Console.ReadLine());
var a = new (int d, int l)[13];
(int w, int h) size = (0, 0);

for (int i = 0; i < 6; i++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    a[i] = a[i + 6] = (input[0], input[1]);
    if (input[0] <= 2) size.w = Math.Max(size.w, input[1]);
    else size.h = Math.Max(size.h, input[1]);
}

for (int i = 0; i < 6; i++)
{
    if ((a[i].l == size.h && a[i + 1].l == size.w) || (a[i + 1].l == size.h && a[i].l == size.w))
    {
        Console.WriteLine((size.w * size.h - a[i + 3].l * a[i + 4].l) * k);
        break;
    }
}