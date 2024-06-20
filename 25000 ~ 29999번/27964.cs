int n = int.Parse(Console.ReadLine());
Console.Write(Console.ReadLine().Split().Where(i => i.Length >= 6 && i[^6..] == "Cheese").ToHashSet().Count >= 4 ? "yummy" : "sad");