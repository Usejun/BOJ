int n = int.Parse(Console.ReadLine());
while (n-- > 0)
{
    var input = Console.ReadLine().Split();
    var s1 = new List<char>(input[0]);
    var s2 = new List<char>(input[1]);

    s1.Sort();
    s2.Sort();

    Console.WriteLine($"{input[0]} & {input[1]} are{(s1.SequenceEqual(s2) ? "" : " NOT")} anagrams.");
}