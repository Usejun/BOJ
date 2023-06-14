int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split().Select(double.Parse).ToList();
    var score = input.Skip(1).ToList();             
    Console.WriteLine($"{score.Where(x => x > score.Average()).Count()*100/input[0]:0.000}%");
}
