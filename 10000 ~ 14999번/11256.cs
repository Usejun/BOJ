int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int candy = input[0], box = input[1], i = 0;
    var size = new List<int>();

    for (; i < box; i++)
    {
        input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        size.Add(input[0] * input[1]);
    }

    size.Sort();
    size.Reverse();

    int sum = 0;
    i = 0;

    for (; i < box; i++)
    {
        if (sum >= candy) break;
        sum += size[i];
    }

    Console.WriteLine(i);

}

