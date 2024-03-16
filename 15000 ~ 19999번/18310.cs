int n = int.Parse(Console.ReadLine());
var a = Console.ReadLine().Split().Select(int.Parse).OrderBy(i => i).ToArray();
Console.Write(a[(n-1)/2]);
